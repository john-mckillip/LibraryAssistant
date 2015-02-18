using LibraryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryViews
{
    public partial class AddBookView : Form
    {
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

            Book book = new Book(title, author, publisher, isbn);
        }
    }
}
