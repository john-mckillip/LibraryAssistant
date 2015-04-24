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
    public partial class EditBookView : Form
    {
        private string updateSuccessString = "The book was successfully updated.";
        private string updateNoSuccessString = "Sorry, there was an error updating the book. Please try again.";
        private string idNoSuccssString = "Sorry, there was an error getting the book. Please try again.";
        private string deleteSuccessString = "The book was successfully deleted.";
        private string deleteNoSuccessString = "Sorry, there was an error deleting the book. Please try again.";

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
            titleTextBox.Text = "";
            authorTextBox.Text = "";
            publisherTextBox.Text = "";
            isbnTextBox.Text = "";
        }

        public EditBookView(List<Media> m)
        {
            InitializeComponent();
            mediaItems = m;

            // Populate the list view columns
            populateListView();

            //Populate the list with the data
            if (File.Exists("books.txt"))
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
            BooksController.SaveBooks(mediaItems);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            EditBookView.ActiveForm.Close();
            BooksView booksView = new BooksView(mediaItems);
            booksView.Show();
        }

        private void getBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = Convert.ToInt32(idTextBox.Text);

                foreach (Media b in mediaItems)
                {
                    if (b is Book)
                    {
                        Book itemAsBook = (Book)b;
                        if (itemAsBook.Id == bookId)
                        {
                            titleTextBox.Text = itemAsBook.Title;
                            authorTextBox.Text = itemAsBook.Author;
                            publisherTextBox.Text = itemAsBook.Publisher;
                            isbnTextBox.Text = itemAsBook.ISBN;
                        }
                    }
                }               
            }

            catch
            {
                MessageBox.Show(idNoSuccssString);
            } 
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextBox.Text != "")
                {
                    int bookId = Convert.ToInt32(idTextBox.Text);
                    int size = mediaItems.Count;
                    foreach (Media b in mediaItems)
                    {
                        if (b is Book && b.Id == bookId)
                        {
                            mediaItems = BooksController.DeleteBook(bookId, mediaItems);
                            break;
                        }
                    }
                          
                    if (mediaItems.Count == size - 1)
                    {
                        MessageBox.Show(deleteSuccessString);
                        ClearBookFields();

                        booksListView.Clear();

                        populateListView();
                        BooksController.PopulateMainBooksViewList(booksListView, mediaItems);
                    }
                    else
                    {
                        MessageBox.Show(deleteNoSuccessString);
                    }
                }
                else
                {
                    MessageBox.Show(deleteNoSuccessString);
                }            
            }
            catch
            {
                MessageBox.Show(deleteNoSuccessString);
            }
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            int empty = 0;
            if (idTextBox.Text != "")
            {
                int bookId = Convert.ToInt32(idTextBox.Text);
                string title = titleTextBox.Text;
                if (title == "")
                {
                    empty = 1;
                }
                string author = authorTextBox.Text;
                if (author == "")
                {
                    empty = 1;
                }
                string publisher = publisherTextBox.Text;
                if (publisher == "")
                {
                    empty = 1;
                }
                string isbn = isbnTextBox.Text;
                if (isbn == "")
                {
                    empty = 1;
                }

                if (empty == 0)
                {
                    mediaItems = BooksController.UpdateBook(bookId, title, author, publisher, isbn, mediaItems);
                    bool success = true;
                    if (success)
                    {
                        MessageBox.Show(updateSuccessString);
                        ClearBookFields();

                        booksListView.Clear();

                        populateListView();
                        BooksController.PopulateMainBooksViewList(booksListView, mediaItems);
                    }
                }
                else
                {
                    MessageBox.Show(updateNoSuccessString);
                }
            }
            else
            {
                MessageBox.Show(updateNoSuccessString);
            }
        }

        private void booksListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbnLabel_Click(object sender, EventArgs e)
        {

        }

        private void publisherLabel_Click(object sender, EventArgs e)
        {

        }

        private void authorLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void isbnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
