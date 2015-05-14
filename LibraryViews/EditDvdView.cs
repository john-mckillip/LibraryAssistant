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
    public partial class EditDvdView : Form
    {
        private string updateSuccessString = "The dvd was successfully updated.";
        private string updateNoSuccessString = "Sorry, there was an error updating the dvd. Please try again.";
        private string idNoSuccssString = "Sorry, there was an error getting the dvd. Please try again.";
        private string deleteSuccessString = "The dvd was successfully deleted.";
        private string deleteNoSuccessString = "Sorry, there was an error deleting the dvd. Please try again.";

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
            titleTextBox.Text = "";
            directorTextBox.Text = "";
            starTextBox.Text = "";
            producerTextBox.Text = "";
        }

        public EditDvdView(List<Media> m)
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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EditDvdView.ActiveForm.Close();
            DvdsView dvdsView = new DvdsView(mediaItems);
            dvdsView.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void getDvdButton_Click(object sender, EventArgs e)
        {
            try
            {
                int dvdId = Convert.ToInt32(idTextBox.Text);

                foreach (Media d in mediaItems)
                {
                    if (d is Dvd)
                    {
                        Dvd itemAsDvd = (Dvd)d;
                        if (itemAsDvd.Id == dvdId)
                        {
                            titleTextBox.Text = itemAsDvd.Title;
                            directorTextBox.Text = itemAsDvd.Director;
                            starTextBox.Text = itemAsDvd.Star;
                            producerTextBox.Text = itemAsDvd.Producer;
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

        private void deleteDvdButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextBox.Text != "")
                {
                    int dvdId = Convert.ToInt32(idTextBox.Text);
                    int size = mediaItems.Count;
                    foreach (Media d in mediaItems)
                    {
                        if (d is Dvd && d.Id == dvdId)
                        {
                            mediaItems = MediaController.DeleteMedia(dvdId, mediaItems);
                            break;
                        }
                    }

                    if (mediaItems.Count == size - 1)
                    {
                        MessageBox.Show(deleteSuccessString);
                        ClearDvdFields();

                        mediaListView.Clear();

                        populateListView();
                        MediaController.PopulateMainDvdsViewList(mediaListView, mediaItems);
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

        private void updateDvdButton_Click(object sender, EventArgs e)
        {
            int empty = 0;
            if (idTextBox.Text != "")
            {
                int dvdId = Convert.ToInt32(idTextBox.Text);
                string title = titleTextBox.Text;
                if (title == "")
                {
                    empty = 1;
                }
                string director = directorTextBox.Text;
                if (director == "")
                {
                    empty = 1;
                }
                string star = starTextBox.Text;
                if (star == "")
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
                    mediaItems = MediaController.UpdateDvd(dvdId, title, director, producer, star, mediaItems);
                    bool success = true;
                    if (success)
                    {
                        MessageBox.Show(updateSuccessString);
                        ClearDvdFields();

                        mediaListView.Clear();

                        populateListView();
                        MediaController.PopulateMainDvdsViewList(mediaListView, mediaItems);
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
