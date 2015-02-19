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

namespace LibraryViews
{
    public partial class AddBookView : Form
    {
        private string successString = "The book was successfully added to inventory.";
        private string noSuccessString = "Sorry, there was an error adding book to inventory.";

        public AddBookView()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string author = authorTextBox.Text;
            string publisher = publisherTextBox.Text;
            string isbn = isbnTextBox.Text;
            bool success = false;

            Book book = new Book(title, author, publisher, isbn);

            if (File.Exists("books.txt"))
            {
                BookSerializer serializer = new BookSerializer();
                BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
                serializedBooks = serializer.DeSerializeObject("books.txt");

                List<Book> booksFromFile = new List<Book>();
                booksFromFile = serializedBooks.Books;

                booksFromFile.Add(book);

                BookObjectToSerialize newSerializedBooks = new BookObjectToSerialize();
                newSerializedBooks.Books = booksFromFile;
                serializer.SerializeObject("books.txt", newSerializedBooks);

                success = true;
            }
            else
            {
                List<Book> booksNew = new List<Book>();
                booksNew.Add(book);

                BookSerializer serializer = new BookSerializer();
                BookObjectToSerialize serializeBook = new BookObjectToSerialize();
                serializeBook.Books = booksNew;
                serializer.SerializeObject("books.txt", serializeBook);

                success = true;
            }
            // Let the user know if the book was added successfully or not.
            if (success)
            {
                successLabel.Text = successString;
                titleTextBox.Text = "";
                authorTextBox.Text = "";
                publisherTextBox.Text = "";
                isbnTextBox.Text = "";
            }
            else
            {
                successLabel.Text = noSuccessString;
            }
        }
    }
}
