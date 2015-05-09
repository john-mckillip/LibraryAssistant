using LibraryModels;
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
    public partial class CheckoutCdView : Form
    {
        private string successString = "The book was checked out successfully.";
        private string noSuccessString = "Sorry, there was an error. Please try again.";

        public static List<Media> mediaItems;

        // Private method that populates the columns of booksListView
        private void populateListView()
        {
            mediaListView.View = View.Details;
            mediaListView.GridLines = false;
            mediaListView.FullRowSelect = true;

            //Add column header
            mediaListView.Columns.Add("Id", 50);
            mediaListView.Columns.Add("Title", 200);
            mediaListView.Columns.Add("Performer", 150);
            mediaListView.Columns.Add("Checked Out", 120);
        }

        private void ClearCdFields()
        {
            idTextBox.Text = "";
        }
        public CheckoutCdView(List<Media> m)
        {
            InitializeComponent();
            mediaItems = m;

            // Populate the list view columns
            populateListView();

            //Populate the list with the data
            if (File.Exists("media.txt"))
            {
                MediaController.PopulateMainCdsViewList(mediaListView, mediaItems);
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
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CheckoutCdView.ActiveForm.Close();
            CdsView cdsView = new CdsView(mediaItems);
            cdsView.Show();
        }

        private void checkoutCdButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "" && customerComboBox.SelectedIndex > -1)
            {
                int cdId = Convert.ToInt32(idTextBox.Text);
                Object selectedItem = customerComboBox.SelectedItem;
                string cId = selectedItem.ToString();
                string[] id = cId.Split(' ');
                int customerId = Convert.ToInt32(id[0]);
                foreach (Media c in mediaItems)
                {
                    if (c is Cd)
                    {
                        Cd itemAsCd = (Cd)c;
                        if (itemAsCd.Id == cdId)
                        {
                            if (!itemAsCd.IsCheckedOut())
                            {
                                itemAsCd.CheckOut();
                            }
                        }
                    }
                }
                bool success = true; 

                if (success)
                {
                    MessageBox.Show(successString);
                    ClearCdFields();

                    mediaListView.Clear();

                    populateListView();
                    MediaController.PopulateMainCdsViewList(mediaListView, mediaItems);
                    customerComboBox.SelectedIndex = -1;
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
