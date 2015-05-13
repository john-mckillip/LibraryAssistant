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
    public partial class CheckInDvdView : Form
    {
        private string successString = "The DVD was checked in successfully.";
        private string noSuccessString = "Sorry, there was an error. Please try again.";

        public static List<Media> mediaItems;

        // Private method that populates the columns of DVDSListView
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
        public CheckInDvdView(List<Media> m)
        {
            InitializeComponent();
            mediaItems = m;

            // Populate the list view columns
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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CheckInDvdView.ActiveForm.Close();
            DvdsView dvdView = new DvdsView(mediaItems);
            dvdView.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void checkInDvdButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                int dvdId = Convert.ToInt32(idTextBox.Text);

                foreach (Media d in mediaItems)
                {
                    if (d is Dvd)
                    {
                        Dvd itemAsDvd = (Dvd)d;
                        if (itemAsDvd.Id == dvdId)
                        {
                            if (itemAsDvd.IsCheckedOut())
                            {
                                itemAsDvd.CheckIn();
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
                }
                else
                {
                    MessageBox.Show(noSuccessString + "1");
                }
            }
            else
            {
                MessageBox.Show(noSuccessString);
            }                      
        }
    }
}
