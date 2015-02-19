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
            booksListView.Columns.Add("ProductName", 100);
            booksListView.Columns.Add("Price", 70);
            booksListView.Columns.Add("Quantity", 70);

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "product_1";
            arr[1] = "100";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            booksListView.Items.Add(itm);

            //Add second item
            arr[0] = "product_2";
            arr[1] = "200";
            arr[2] = "20";
            itm = new ListViewItem(arr);
            booksListView.Items.Add(itm);
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookView addBooks = new AddBookView();
            BooksView.ActiveForm.Hide();
            addBooks.Show();
        }
    }
}
