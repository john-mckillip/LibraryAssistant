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
        public BooksView()
        {
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
            if (File.Exists("books.txt"))
            {
                BooksController.PopulateMainBooksViewList(booksListView);
            }
            else
            {
                return;
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookView addBooks = new AddBookView();
            BooksView.ActiveForm.Hide();
            addBooks.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BooksView.ActiveForm.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
