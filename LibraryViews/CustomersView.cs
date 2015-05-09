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
    public partial class CustomersView : Form
    {
        public CustomersView()
        {
            // Populate the list view with Book objects
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
            if (File.Exists("customers.txt"))
            {
                CustomersController.PopulateMainCustomersViewList(customersListView);
            }
            else
            {
                return;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CustomersView.ActiveForm.Close();
            Main main = new Main();
            main.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            CustomersView.ActiveForm.Close();
            AddCustomerView addCustomers = new AddCustomerView();
            addCustomers.Show();
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            CustomersView.ActiveForm.Close();
            EditCustomerView editCust = new EditCustomerView();
            editCust.Show();
        }
    }
}
