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
    public partial class CheckInBookView : Form
    {
        private string successString = "The book was checked in successfully.";
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
            booksListView.Columns.Add("Checked Out", 120);
        }

        private void ClearBookFields()
        {
            idTextBox.Text = "";
        }

        public CheckInBookView(List<Media> m)
        {
            InitializeComponent();

            mediaItems = m;

            // Populate the list view columns
            populateListView();

            //Populate the list with the data
            if (File.Exists("media.txt"))
            {
                BooksController.PopulateMainBooksViewList(booksListView, mediaItems);
            }
            else
            {
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            BooksController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EditBookView.ActiveForm.Close();
            BooksView booksView = new BooksView(mediaItems);
            booksView.Show();
        }

        private void checkInBookButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                int bookId = Convert.ToInt32(idTextBox.Text);

                foreach (Media b in mediaItems)
                {
                    if (b is Book)
                    {
                        Book itemAsBook = (Book)b;
                        if (itemAsBook.Id == bookId)
                        {
                            if (itemAsBook.IsCheckedOut())
                            {
                                itemAsBook.CheckIn();
                            }
                        }
                    }
                }

                bool success = true;

                if (success)
                {
                    MessageBox.Show(successString);
                    ClearBookFields();

                    booksListView.Clear();

                    populateListView();
                    BooksController.PopulateMainBooksViewList(booksListView, mediaItems);
                }
                else
                {
                    MessageBox.Show(noSuccessString + "1");
                }
            }
            else
            {
                MessageBox.Show(noSuccessString);
            }                      
        }
    }
}
