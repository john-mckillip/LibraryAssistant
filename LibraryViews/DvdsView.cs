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
    public partial class DvdsView : Form
    {
        public static List<Media> mediaItems;

        public DvdsView(List<Media> mediaFromFile)
        {
            mediaItems = mediaFromFile;
            InitializeComponent();

            mediaListView.View = View.Details;
            mediaListView.GridLines = false;
            mediaListView.FullRowSelect = true;

            //Add column header
            mediaListView.Columns.Add("Id", 50);
            mediaListView.Columns.Add("Title", 200);
            mediaListView.Columns.Add("Director", 150);
            mediaListView.Columns.Add("Checked Out", 120);

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
            MediaController.SaveMedia(mediaItems);
            DvdsView.ActiveForm.Close();
            Main main = new Main();
            main.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void addDvdButton_Click(object sender, EventArgs e)
        {
            AddDvdView addDvdView = new AddDvdView(mediaItems);
            DvdsView.ActiveForm.Hide();
            addDvdView.Show();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            CheckOutDvdView checkOutDvd = new CheckOutDvdView(mediaItems);
            DvdsView.ActiveForm.Hide();
            checkOutDvd.Show();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            CheckInDvdView checkInDvd = new CheckInDvdView(mediaItems);
            DvdsView.ActiveForm.Hide();
            checkInDvd.Show();
        }
    }
}
