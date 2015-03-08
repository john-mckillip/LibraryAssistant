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
    public partial class AddCustomerView : Form
    {
        private string successString = "The new customer was successfully added.";
        private string noSuccessString = "Sorry, there was an error adding the new customer.";

        public AddCustomerView()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AddCustomerView.ActiveForm.Close();
            CustomersView customers = new CustomersView();
            customers.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            bool allFeildsFull = true;
            string firstName = firstNameTextBox.Text;
            if (firstName == "")
            {
                allFeildsFull = false;
            }
            string lastName = lastNameTextBox.Text;
            if (lastName == "")
            {
                allFeildsFull = false;
            }
            string phoneNum = phoneTextBox.Text;
            if (phoneNum == "")
            {
                allFeildsFull = false;
            }
            string email = emailTextBox.Text;
            if (email == "")
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
                Customer customer = new Customer(firstName,lastName,phoneNum,email);

                if (File.Exists("customers.txt"))
                {
                    success = CustomersController.AddCustomerToExistingList(customer);
                }

                else
                {
                    success = CustomersController.AddCustomerToNewList(customer);
                }
                // Let the user know if the book was added successfully or not.
                if (success)
                {
                    MessageBox.Show(successString);
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    phoneTextBox.Text = "";
                    emailTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show(noSuccessString);
                }
            }
        }
    }
}
