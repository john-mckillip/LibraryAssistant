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
    public partial class CheckInCdView : Form
    {
        private string successString = "The cd was checked in successfully.";
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

        public CheckInCdView(List<Media> m)
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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CheckInCdView.ActiveForm.Close();
            CdsView cdsView = new CdsView(mediaItems);
            cdsView.Show();
        }

        private void checkInCdButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                int cdId = Convert.ToInt32(idTextBox.Text);

                foreach (Media c in mediaItems)
                {
                    if (c is Cd)
                    {
                        Cd itemAsCd = (Cd)c;
                        if (itemAsCd.Id == cdId)
                        {
                            if (itemAsCd.IsCheckedOut())
                            {
                                itemAsCd.CheckIn();
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
