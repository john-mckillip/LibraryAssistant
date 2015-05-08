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
    public partial class EditCdView : Form
    {
        private string updateSuccessString = "The cd was successfully updated.";
        private string updateNoSuccessString = "Sorry, there was an error updating the cd. Please try again.";
        private string idNoSuccssString = "Sorry, there was an error getting the cd. Please try again.";
        private string deleteSuccessString = "The cd was successfully deleted.";
        private string deleteNoSuccessString = "Sorry, there was an error deleting the cd. Please try again.";

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
            titleTextBox.Text = "";
            performerTextBox.Text = "";
            publisherTextBox.Text = "";
            producerTextBox.Text = "";
        }

        public EditCdView(List<Media> m)
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
            EditCdView.ActiveForm.Close();
            CdsView cdsView = new CdsView(mediaItems);
            cdsView.Show();
        }

        private void getCdButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cdId = Convert.ToInt32(idTextBox.Text);

                foreach (Media b in mediaItems)
                {
                    if (b is Cd)
                    {
                        Cd itemAsCd = (Cd)b;
                        if (itemAsCd.Id == cdId)
                        {
                            titleTextBox.Text = itemAsCd.Title;
                            performerTextBox.Text = itemAsCd.Performer;
                            publisherTextBox.Text = itemAsCd.Publisher;
                            producerTextBox.Text = itemAsCd.Producer;
                            break;
                        }
                    }
                }
            }

            catch
            {
                MessageBox.Show(idNoSuccssString);
            } 
        }

        private void deleteCDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextBox.Text != "")
                {
                    int cdId = Convert.ToInt32(idTextBox.Text);
                    int size = mediaItems.Count;
                    foreach (Media b in mediaItems)
                    {
                        if (b is Cd && b.Id == cdId)
                        {
                            mediaItems = MediaController.DeleteMedia(cdId, mediaItems);
                            break;
                        }
                    }

                    if (mediaItems.Count == size - 1)
                    {
                        MessageBox.Show(deleteSuccessString);
                        ClearCdFields();

                        mediaListView.Clear();

                        populateListView();
                        MediaController.PopulateMainCdsViewList(mediaListView, mediaItems);
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

        private void updateCdButton_Click(object sender, EventArgs e)
        {
            int empty = 0;
            if (idTextBox.Text != "")
            {
                int cdId = Convert.ToInt32(idTextBox.Text);
                string title = titleTextBox.Text;
                if (title == "")
                {
                    empty = 1;
                }
                string performer = performerTextBox.Text;
                if (performer == "")
                {
                    empty = 1;
                }
                string publisher = publisherTextBox.Text;
                if (publisher == "")
                {
                    empty = 1;
                }
                string producer = producerTextBox.Text;
                if (producer == "")
                {
                    empty = 1;
                }

                if (empty == 0)
                {
                    mediaItems = MediaController.UpdateCd(cdId, title, performer, producer, publisher, mediaItems);
                    bool success = true;
                    if (success)
                    {
                        MessageBox.Show(updateSuccessString);
                        ClearCdFields();

                        mediaListView.Clear();

                        populateListView();
                        MediaController.PopulateMainCdsViewList(mediaListView, mediaItems);
                    }
                }
                else
                {
                    MessageBox.Show(updateNoSuccessString);
                }
            }
            else
            {
                MessageBox.Show(updateNoSuccessString);
            }
        }
    }
}
