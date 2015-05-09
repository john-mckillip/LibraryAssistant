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
    public partial class SearchBookView : Form
    {
        private string noSuccessString = "The book was nowhere to be found.";
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

        public SearchBookView(List<Media> mediaFromFile)
        {
            InitializeComponent();
            mediaItems = mediaFromFile;
            populateListView();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {            
            SearchBookView.ActiveForm.Close();
            BooksView booksView = new BooksView(mediaItems);
            booksView.Show();       
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
           
            if (titleTextBox.Text != "")
            {
                string title = titleTextBox.Text;

                foreach (Media b in mediaItems)
                {
                    // Comparing strings not numbers Duke!s
                    if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        MessageBox.Show("Found It!");
                        booksListView.Clear();
                        populateListView();
                        MediaController.PopulateSearchViewList(booksListView, b);
                    }
                }
            }                   

            if (!found)
            {
                MessageBox.Show(noSuccessString);  
            }           
        }

        private void isbnSearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;

            if (isbnTextBox.Text != "")
            {
                string isbn = isbnTextBox.Text;

                foreach (Media b in mediaItems)
                {
                    if (b is Book)
                    {
                        Book itemAsBook = (Book)b;
                        if (itemAsBook.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;
                            MessageBox.Show("Found It!");
                            booksListView.Clear();
                            populateListView();
                            MediaController.PopulateSearchViewList(booksListView, b);
                            break;
                        }
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show(noSuccessString);
            }
        }
    }
}
