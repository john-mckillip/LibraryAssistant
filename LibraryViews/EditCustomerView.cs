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
        private string updateSuccessString = "The customer was successfully updated.";
        private string updateNoSuccessString = "Sorry, there was an error updating the customer. Please try again.";
        private string idNoSuccssString = "Sorry, there was an error getting the customer. Please try again.";
        private string deleteSuccessString = "The customer was successfully deleted.";
        private string deleteNoSuccessString = "Sorry, there was an error deleting the customer. Please try again.";

        private void ClearCustomerFields()
        {
            idTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void populateListView()
        {
            customersListView.View = View.Details;
            customersListView.GridLines = false;
            customersListView.FullRowSelect = true;

            //Add column header
            customersListView.Columns.Add("Account #", 90);
            customersListView.Columns.Add("Name", 130);
            customersListView.Columns.Add("Phone", 120);
            customersListView.Columns.Add("Email", 190);
        }
        public EditCustomerView()
        {
            InitializeComponent();
            
            //Populate the list with the data
            populateListView();

            if (File.Exists("customers.txt"))
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
            try
            {
                int customerId = Convert.ToInt32(idTextBox.Text);
                Customer c = CustomersController.GetCustomer(customerId);

                firstNameTextBox.Text = c.GetFirstName();
                lastNameTextBox.Text = c.GetLastName();
                phoneTextBox.Text = c.GetPhoneNumber();
                emailTextBox.Text = c.GetEmailAddress();
            }

            catch
            {
                MessageBox.Show(idNoSuccssString);
            } 
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextBox.Text != "")
                {
                    int customerId = Convert.ToInt32(idTextBox.Text);
                    bool success = CustomersController.DeleteCustomer(customerId);

                    if (success)
                    {
                        MessageBox.Show(deleteSuccessString);
                        ClearCustomerFields();
                        customersListView.Clear();

                        populateListView();
                        CustomersController.PopulateMainCustomersViewList(customersListView);
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
    }
}
