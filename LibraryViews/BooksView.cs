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
    public partial class BooksView : Form
    {
        public BooksView()
        {
            // Populate the list view with Book objects
            InitializeComponent();
            booksListView.View = View.Details;
            booksListView.GridLines = true;
            booksListView.FullRowSelect = true;

            //Add column header
            booksListView.Columns.Add("Id", 50);
            booksListView.Columns.Add("Title", 200);
            booksListView.Columns.Add("Author", 150);
            booksListView.Columns.Add("Checked Out", 120);

            if (File.Exists("books.txt"))
            {
                List<Book> booksFromFile = new List<Book>();

                BookSerializer serializer = new BookSerializer();
                BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
                serializedBooks = serializer.DeSerializeObject("books.txt");
                booksFromFile = serializedBooks.Books;

                foreach (Book b in booksFromFile)
                {
                    ListViewItem itm;
                    string[] bk = new String[4];

                    bk[0] = b.GetId().ToString();
                    bk[1] = b.GetTitle();
                    bk[2] = b.GetAuthor();
                    // Is it in stock?
                    if(b.IsCheckedOut()) {
                        bk[3] = "Out of Stock";
                    }
                    else
                    {
                        bk[3] = "In Stock";
                    }
                    itm = new ListViewItem(bk);
                    booksListView.Items.Add(itm);
                }
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
