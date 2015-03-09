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

        public EditBookView()
        {
            InitializeComponent();

            // Populate the list view columns
            populateListView();

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            EditBookView.ActiveForm.Close();
            BooksView booksView = new BooksView();
            booksView.Show();
        }

        private void getBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = Convert.ToInt32(idTextBox.Text);
                Book b = BooksController.GetBook(bookId);

                titleTextBox.Text = b.GetTitle();
                authorTextBox.Text = b.GetAuthor();
                publisherTextBox.Text = b.GetPublisher();
                isbnTextBox.Text = b.GetIsbn();
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
                    bool success = BooksController.DeleteBook(bookId);

                    if (success)
                    {
                        MessageBox.Show(deleteSuccessString);
                        ClearBookFields();

                        booksListView.Clear();

                        populateListView();
                        BooksController.PopulateMainBooksViewList(booksListView);
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
                    bool success = BooksController.UpdateBook(bookId, title, author, publisher, isbn);
                    if (success == true)
                    {
                        MessageBox.Show(updateSuccessString);
                        ClearBookFields();

                        booksListView.Clear();

                        populateListView();
                        BooksController.PopulateMainBooksViewList(booksListView);
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
