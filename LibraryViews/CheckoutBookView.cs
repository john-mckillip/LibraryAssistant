﻿using LibraryModels;
using LibraryViews.Controllers;
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
    public partial class CheckoutBookView : Form
    {
        private string successString = "The book was checked out successfully.";
        private string noSuccessString = "Sorry, there was an error. Please try again.";

        // Private method that populates the columns of booksListView
        private void populateListView()
        {
            booksListView.View = View.Details;
            booksListView.GridLines = false;
            booksListView.FullRowSelect = true;

            //Add column header
            booksListView.Columns.Add("Id", 50);
            booksListView.Columns.Add("Title", 200);
            booksListView.Columns.Add("Author", 150);
            booksListView.Columns.Add("Checked Out", 120);
        }

        private void ClearBookFields()
        {
            idTextBox.Text = "";
        }

        public CheckoutBookView()
        {
            InitializeComponent();

            // Populate the list view columns
            populateListView();

            //Populate the list with the data
            if (File.Exists("books.txt"))
            {
                BooksController.PopulateMainBooksViewList(booksListView);
            }
            else
            {
                return;
            }

            if (File.Exists("customers.txt"))
            {
                CustomersController.PopulateCustomersComboBox(customerComboBox);
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
            CheckoutBookView.ActiveForm.Close();
            BooksView books = new BooksView();
            books.Show();
        }

        private void checkoutBookButton_Click(object sender, EventArgs e)
        {

            int empty = 0;
            if (idTextBox.Text != "")
            {
                int bookId = Convert.ToInt32(idTextBox.Text);
                Object selectedItem = customerComboBox.SelectedItem;
                string cId = selectedItem.ToString();
                if (cId == "")
                {
                    empty = 1;
                }

                if (empty == 0)
                {
                    string[] id = cId.Split(' ');
                    int customerId = Convert.ToInt32(id[0]);
                    bool success = BooksController.CheckoutBook(bookId);

                    if (success)
                    {
                        MessageBox.Show(successString);
                        ClearBookFields();

                        booksListView.Clear();

                        populateListView();
                        BooksController.PopulateMainBooksViewList(booksListView);
                    }
                    else
                    {
                        MessageBox.Show(noSuccessString);
                    }
                }
                else
                {
                    MessageBox.Show(noSuccessString);
                }
            }
            else
            {
                MessageBox.Show(noSuccessString);
            }                                      
        }
    }
}