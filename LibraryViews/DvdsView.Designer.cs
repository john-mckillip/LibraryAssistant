namespace LibraryViews
{
    partial class DvdsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mediaListView = new System.Windows.Forms.ListView();
            this.addDvdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(25, 582);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(634, 46);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.BackColor = System.Drawing.Color.Black;
            this.checkInButton.FlatAppearance.BorderSize = 0;
            this.checkInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInButton.ForeColor = System.Drawing.Color.White;
            this.checkInButton.Location = new System.Drawing.Point(25, 641);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(310, 46);
            this.checkInButton.TabIndex = 15;
            this.checkInButton.Text = "CHECK IN DVD";
            this.checkInButton.UseVisualStyleBackColor = false;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Black;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(25, 521);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(634, 46);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "EDIT DVD";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Black;
            this.checkoutButton.FlatAppearance.BorderSize = 0;
            this.checkoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkoutButton.ForeColor = System.Drawing.Color.White;
            this.checkoutButton.Location = new System.Drawing.Point(349, 641);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(310, 46);
            this.checkoutButton.TabIndex = 13;
            this.checkoutButton.Text = "CHECK OUT DVD";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(25, 14);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "GO BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(554, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mediaListView
            // 
            this.mediaListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mediaListView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaListView.ForeColor = System.Drawing.Color.Black;
            this.mediaListView.Location = new System.Drawing.Point(25, 60);
            this.mediaListView.Name = "mediaListView";
            this.mediaListView.Size = new System.Drawing.Size(634, 371);
            this.mediaListView.TabIndex = 10;
            this.mediaListView.UseCompatibleStateImageBehavior = false;
            this.mediaListView.View = System.Windows.Forms.View.Details;
            // 
            // addDvdButton
            // 
            this.addDvdButton.BackColor = System.Drawing.Color.Black;
            this.addDvdButton.FlatAppearance.BorderSize = 0;
            this.addDvdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addDvdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDvdButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDvdButton.ForeColor = System.Drawing.Color.White;
            this.addDvdButton.Location = new System.Drawing.Point(25, 460);
            this.addDvdButton.Name = "addDvdButton";
            this.addDvdButton.Size = new System.Drawing.Size(634, 46);
            this.addDvdButton.TabIndex = 9;
            this.addDvdButton.Text = "ADD DVD";
            this.addDvdButton.UseVisualStyleBackColor = false;
            this.addDvdButton.Click += new System.EventHandler(this.addDvdButton_Click);
            // 
            // DvdsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 741);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mediaListView);
            this.Controls.Add(this.addDvdButton);
            this.Name = "DvdsView";
            this.Text = "Dvds";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView mediaListView;
        private System.Windows.Forms.Button addDvdButton;
    }
}