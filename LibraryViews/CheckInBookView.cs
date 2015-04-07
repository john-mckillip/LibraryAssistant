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

        public static List<Book> books;

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

        public CheckInBookView(List<Book> booksFromFile)
        {
            InitializeComponent();

            books = booksFromFile;

            // Populate the list view columns
            populateListView();

            //Populate the list with the data
            if (File.Exists("books.txt"))
            {
                BooksController.PopulateCheckInBooksViewList(booksListView);
            }
            else
            {
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            BooksController.SaveBooks(books);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EditBookView.ActiveForm.Close();
            BooksView booksView = new BooksView(books);
            booksView.Show();
        }

        private void checkInBookButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                int bookId = Convert.ToInt32(idTextBox.Text);
                bool success = BooksController.CheckInBook(bookId);

                if (success)
                {
                    MessageBox.Show(successString);
                    ClearBookFields();

                    booksListView.Clear();

                    populateListView();
                    BooksController.PopulateCheckInBooksViewList(booksListView);
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
