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
    public partial class AddDvdView : Form
    {
        private string successString = "The dvd was successfully added to inventory.";

        public static List<Media> mediaItems;

        public AddDvdView(List<Media> d)
        {
            InitializeComponent();
            mediaItems = d;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AddDvdView.ActiveForm.Close();
            DvdsView dvdsView = new DvdsView(mediaItems);
            dvdsView.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(mediaItems);
            Application.Exit();
        }

        private void addDvdButton_Click(object sender, EventArgs e)
        {
            bool allFeildsFull = true;
            string title = titleTextBox.Text;
            if (title == "")
            {
                allFeildsFull = false;
            }
            string director = directorTextBox.Text;
            if (director == "")
            {
                allFeildsFull = false;
            }
            string producer = producerTextBox.Text;
            if (producer == "")
            {
                allFeildsFull = false;
            }
            string star = starTextBox.Text;
            if (star == "")
            {
                allFeildsFull = false;
            }
            // Only forms with all fields completed shall pass
            // If that is false, display an error message
            // and pause program
            if (allFeildsFull == false)
            {
                MessageBox.Show("ERROR! All fields must be filled out.");
            }
            else // All fields have data, so continue.
            {
                Dvd dvd = new Dvd(title, director, producer, star);
                mediaItems.Add(dvd);

                // Let the user know the book was added successfully. 
                MessageBox.Show(successString);
                titleTextBox.Text = "";
                directorTextBox.Text = "";
                producerTextBox.Text = "";
                starTextBox.Text = "";
            }
        }
    }
}
