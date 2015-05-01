using LibraryModels;
using LibraryViews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryViews
{
    public partial class CheckoutBookView : Form
    {
        private string successString = "The book was checked out successfully.";
        private string noSuccessString = "Sorry, there was an error. Please try again.";

        public static List<Media> mediaItems;

        // Private method that populates the columns of booksListView
        private void populateListView()
        {
            booksListView.View = View.Details;
            booksListView.GridLines = false;
            booksListView.FullRowSelect = true;

            //Add column header
            booksListView.Columns.Add("Id", 50);
            booksListView.Columns.Add("Title", 200);
            booksListView.Columns.Add("Author", 150);
            booksListView.Columns.Add("ISBN", 110);
            booksListView.Columns.Add("Checked Out", 120);
        }

        private void ClearBookFields()
        {
            idTextBox.Text = "";
        }

        public CheckoutBookView(List<Media> m)
        {
            InitializeComponent();

            mediaItems = m;

            // Populate the list view columns
            populateListView();

            //Populate the list with the data
            if (File.Exists("media.txt"))
            {
                MediaController.PopulateMainBooksViewList(booksListView, mediaItems);
            }
            else
            {
                return;
            }

            if (File.Exists("customers.txt"))
            {
                CustomersController.PopulateCustomersComboBox(customerComboBox);
            }
            else
            {
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CheckoutBookView.ActiveForm.Close();
            BooksView booksView = new BooksView(mediaItems);
            booksView.Show();
        }

        private void checkoutBookButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "" && customerComboBox.SelectedIndex > -1 )
            {
                int bookId = Convert.ToInt32(idTextBox.Text);
                Object selectedItem = customerComboBox.SelectedItem;
                string cId = selectedItem.ToString();                              
                string[] id = cId.Split(' ');
                int customerId = Convert.ToInt32(id[0]);
                foreach (Media b in mediaItems)
                {
                    if (b is Book)
                    {
                        Book itemAsBook = (Book)b;
                        if (itemAsBook.Id == bookId)
                        {
                            if (!itemAsBook.IsCheckedOut())
                            {
                                itemAsBook.CheckOut();
                            }
                        }
                    }
                }
                bool success = true; //BooksController.CheckoutBook(bookId);

                if (success)
                {
                    MessageBox.Show(successString);
                    ClearBookFields();

                    booksListView.Clear();

                    populateListView();
                    MediaController.PopulateMainBooksViewList(booksListView, mediaItems);
                    customerComboBox.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(noSuccessString);
                }
            }
            else
            {
                MessageBox.Show(noSuccessString);
            }                                      
        }
    }
}
