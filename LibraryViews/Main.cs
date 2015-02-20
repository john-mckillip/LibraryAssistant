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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            BooksView books = new BooksView();
            Main.ActiveForm.Hide();
            books.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            CustomersView customers = new CustomersView();
            Main.ActiveForm.Hide();
            customers.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
