using LibraryModels;
using LibraryViews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryViews
{
    public partial class SearchDvdView : Form
    {
        private string noSuccessString = "The dvd was nowhere to be found.";
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

        public SearchDvdView(List<Media> m)
        {
            InitializeComponent();
            mediaItems = m;
            populateListView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SearchDvdView.ActiveForm.Close();
            DvdsView dvdsView = new DvdsView(mediaItems);
            dvdsView.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void titleSearchButton_Click(object sender, EventArgs e)
        {           
            bool found = false;

            if (titleTextBox.Text != "")
            {
                string title = titleTextBox.Text;

                foreach (Media d in mediaItems)
                {
                    if (d is Dvd)
                    {
                        Dvd itemAsDvd = (Dvd)d;
                        if (itemAsDvd.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;
                            MessageBox.Show("Found It!");
                            mediaListView.Clear();
                            populateListView();
                            MediaController.PopulateDvdsSearchViewList(mediaListView, d);
                            break;
                        }
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show(noSuccessString);
            }

        }
    }
}
