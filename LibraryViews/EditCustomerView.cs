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
    public partial class EditCustomerView : Form
    {
        public EditCustomerView()
        {
            InitializeComponent();
            customersListView.View = View.Details;
            customersListView.GridLines = false;
            customersListView.FullRowSelect = true;

            //Add column header
            customersListView.Columns.Add("Account #", 90);
            customersListView.Columns.Add("Name", 130);
            customersListView.Columns.Add("Phone", 120);
            customersListView.Columns.Add("Email", 190);

            //Populate the list with the data
            if (File.Exists("books.txt"))
            {
                CustomersController.PopulateMainCustomersViewList(customersListView);
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
            EditCustomerView.ActiveForm.Close();
            CustomersView custView = new CustomersView();
            custView.Show();
        }

        private void getCustomerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
