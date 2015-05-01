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
    public partial class AddCdView : Form
    {
        private string successString = "The cd was successfully added to inventory.";
        // private string noSuccessString = "Sorry, there was an error adding book to inventory.";

        public static List<Media> media;

        public AddCdView(List<Media> c)
        {
            InitializeComponent();
            media = c;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MediaController.SaveMedia(media);
            Application.Exit();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            bool allFeildsFull = true;
            string title = titleTextBox.Text;
            if (title == "")
            {
                allFeildsFull = false;
            }
            string performer = performerTextBox.Text;
            if (performer == "")
            {
                allFeildsFull = false;
            }
            string producer = producerTextBox.Text;
            if (producer == "")
            {
                allFeildsFull = false;
            }
            string publisher = publisherTextBox.Text;
            if (publisher == "")
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
                Cd cd = new Cd(title, performer, producer, publisher);
                media.Add(cd);

                // Let the user know the book was added successfully. 
                MessageBox.Show(successString);
                titleTextBox.Text = "";
                performerTextBox.Text = "";
                publisherTextBox.Text = "";
                producerTextBox.Text = "";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AddCdView.ActiveForm.Close();
            CdsView cdsView = new CdsView(media);
            cdsView.Show();
        }
    }
}
