using LibraryModels;
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
using LibraryViews.Controllers;

namespace LibraryViews
{
    public partial class BooksView : Form
    {
        public static List<Media> mediaItems;

        public BooksView(List<Media> mediaFromFile)
        {
            mediaItems = mediaFromFile;

            // Populate the list view with Book objects
            InitializeComponent();
            booksListView.View = View.Details;
            booksListView.GridLines = false;
            booksListView.FullRowSelect = true;

            //Add column header
            booksListView.Columns.Add("Id", 50);
            booksListView.Columns.Add("Title", 200);
            booksListView.Columns.Add("Author", 150);
            booksListView.Columns.Add("Checked Out", 120);

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

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookView addBooks = new AddBookView(mediaItems);
            BooksView.ActiveForm.Hide();
            addBooks.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditBookView editBook = new EditBookView(mediaItems);
            BooksView.ActiveForm.Hide();
            editBook.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            BooksController.SaveBooks(mediaItems);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BooksController.SaveBooks(mediaItems);
            BooksView.ActiveForm.Close();
            Main main = new Main();
            main.Show();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            CheckoutBookView checkoutBook = new CheckoutBookView(mediaItems);
            BooksView.ActiveForm.Hide();
            checkoutBook.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckInBookView checkInBook = new CheckInBookView(mediaItems);
            BooksView.ActiveForm.Hide();
            checkInBook.Show();
        }
    }
}
