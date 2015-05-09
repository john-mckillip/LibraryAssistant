namespace LibraryViews
{
    partial class SearchBookView
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
            this.isbnSearchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.booksListView = new System.Windows.Forms.ListView();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isbnSearchButton
            // 
            this.isbnSearchButton.BackColor = System.Drawing.Color.Black;
            this.isbnSearchButton.FlatAppearance.BorderSize = 0;
            this.isbnSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.isbnSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isbnSearchButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.isbnSearchButton.ForeColor = System.Drawing.Color.White;
            this.isbnSearchButton.Location = new System.Drawing.Point(23, 458);
            this.isbnSearchButton.Name = "isbnSearchButton";
            this.isbnSearchButton.Size = new System.Drawing.Size(117, 39);
            this.isbnSearchButton.TabIndex = 26;
            this.isbnSearchButton.Text = "SEARCH";
            this.isbnSearchButton.UseVisualStyleBackColor = false;
            this.isbnSearchButton.Click += new System.EventHandler(this.isbnSearchButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(25, 27);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 23;
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
            this.exitButton.Location = new System.Drawing.Point(551, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // booksListView
            // 
            this.booksListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksListView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksListView.ForeColor = System.Drawing.Color.Black;
            this.booksListView.Location = new System.Drawing.Point(25, 81);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(631, 278);
            this.booksListView.TabIndex = 21;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(370, 406);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(290, 35);
            this.titleTextBox.TabIndex = 27;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextBox.Location = new System.Drawing.Point(25, 406);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(290, 35);
            this.isbnTextBox.TabIndex = 30;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(368, 382);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 21);
            this.titleLabel.TabIndex = 31;
            this.titleLabel.Text = "Title";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.Location = new System.Drawing.Point(22, 380);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(60, 21);
            this.isbnLabel.TabIndex = 34;
            this.isbnLabel.Text = "ISBN #";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(370, 458);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 39);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 733);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.isbnSearchButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.booksListView);
            this.Name = "SearchBookView";
            this.Text = "Search for a Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isbnSearchButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Button searchButton;
    }
}