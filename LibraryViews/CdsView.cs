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
    public partial class CdsView : Form
    {
        public static List<Media> mediaItems;

        public CdsView(List<Media> mediaFromFile)
        {
            mediaItems = mediaFromFile;

            InitializeComponent();
            mediaListView.View = View.Details;
            mediaListView.GridLines = false;
            mediaListView.FullRowSelect = true;

            //Add column header
            mediaListView.Columns.Add("Id", 50);
            mediaListView.Columns.Add("Title", 200);
            mediaListView.Columns.Add("Performer", 150);
            mediaListView.Columns.Add("Checked Out", 120);

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
            MediaController.SaveMedia(mediaItems);
            CdsView.ActiveForm.Close();
            Main main = new Main();
            main.Show();
        }

        private void addCdButton_Click(object sender, EventArgs e)
        {
            AddCdView addCdView = new AddCdView(mediaItems);
            CdsView.ActiveForm.Hide();
            addCdView.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditCdView editCd = new EditCdView(mediaItems);
            CdsView.ActiveForm.Close();
            editCd.Show();
        }
    }
}
