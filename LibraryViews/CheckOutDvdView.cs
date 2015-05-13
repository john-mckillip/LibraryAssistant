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
    public partial class CheckOutDvdView : Form
    {
        private string successString = "The dvd was checked out successfully.";
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
            mediaListView.Columns.Add("Director", 150);
            mediaListView.Columns.Add("Checked Out", 120);
        }

        private void ClearDvdFields()
        {
            idTextBox.Text = "";
        }

        public CheckOutDvdView(List<Media> m)
        {
            InitializeComponent();
            mediaItems = m;

            populateListView();
            //Populate the list with the data
            if (File.Exists("media.txt"))
            {
                MediaController.PopulateMainDvdsViewList(mediaListView, mediaItems);
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

        private void backButton_Click(object sender, EventArgs e)
        {
            CheckOutDvdView.ActiveForm.Close();
            DvdsView dvdsView = new DvdsView(mediaItems);
            dvdsView.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void checkoutDvdButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "" && customerComboBox.SelectedIndex > -1)
            {
                int dvdId = Convert.ToInt32(idTextBox.Text);
                Object selectedItem = customerComboBox.SelectedItem;
                string dId = selectedItem.ToString();
                string[] id = dId.Split(' ');
                int customerId = Convert.ToInt32(id[0]);
                foreach (Media d in mediaItems)
                {
                    if (d is Dvd)
                    {
                        Dvd itemAsDvd = (Dvd)d;
                        if (itemAsDvd.Id == dvdId)
                        {
                            if (!itemAsDvd.IsCheckedOut())
                            {
                                itemAsDvd.CheckOut();
                            }
                        }
                    }
                }
                bool success = true;

                if (success)
                {
                    MessageBox.Show(successString);
                    ClearDvdFields();

                    mediaListView.Clear();

                    populateListView();
                    MediaController.PopulateMainDvdsViewList(mediaListView, mediaItems);
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
