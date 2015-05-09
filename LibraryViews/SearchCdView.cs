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
    public partial class SearchCdView : Form
    {

        private string noSuccessString = "The cd was nowhere to be found.";
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

        public SearchCdView(List<Media> m)
        {
            InitializeComponent();
            mediaItems = m;
            populateListView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SearchCdView.ActiveForm.Close();
            CdsView cdsView = new CdsView(mediaItems);
            cdsView.Show(); 
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

                foreach (Media c in mediaItems)
                {
                    if (c is Cd)
                    {
                        Cd itemAsCd = (Cd)c;
                        if (itemAsCd.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;
                            MessageBox.Show("Found It!");
                            mediaListView.Clear();
                            populateListView();
                            MediaController.PopulateCdSearchViewList(mediaListView, c);
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
