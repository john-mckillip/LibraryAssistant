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
    public partial class AddBookView : Form
    {
        private string successString = "The book was successfully added to inventory.";
        private string noSuccessString = "Sorry, there was an error adding book to inventory.";

        public static List<Book> books;

        public AddBookView(List<Book> b)
        {
            InitializeComponent();
            books = b;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            bool allFeildsFull = true;
            string title = titleTextBox.Text;
            if (title == "")
            {
                allFeildsFull = false;
            }
            string author = authorTextBox.Text;
            if (author == "")
            {
                allFeildsFull = false;
            }
            string publisher = publisherTextBox.Text;
            if (publisher == "")
            {
                allFeildsFull = false;
            }
            string isbn = isbnTextBox.Text;
            if (isbn == "")
            {
                allFeildsFull = false;
            }
            // Only forms with all fields completed shall pass
            // If that is false, display an error message
            // and pause program
            if (allFeildsFull == false)
            {
                MessageBox.Show("ERROR! All fields must be filled out.");
            }
            else // All fields have data, so continue.
            {
                bool success = false;
                Book book = new Book(title, author, publisher, isbn);

                if (File.Exists("books.txt"))
                {
                    //success = BooksController.AddBookToExistingList(book);
                    books.Add(book);
                    success = true;
                }
                else
                {
                    success = BooksController.AddBookToNewList(book);
                }
                // Let the user know if the book was added successfully or not.
                if (success)
                {
                    MessageBox.Show(successString);
                    titleTextBox.Text = "";
                    authorTextBox.Text = "";
                    publisherTextBox.Text = "";
                    isbnTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show(noSuccessString);
                }
            } 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            BooksController.SaveBooks(books);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AddBookView.ActiveForm.Close();
            BooksView booksView = new BooksView(books);
            booksView.Show();
        }
    }
}
