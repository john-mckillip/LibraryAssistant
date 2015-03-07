namespace LibraryViews
{
    partial class AddBookView
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(27, 142);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(216, 35);
            this.titleTextBox.TabIndex = 0;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(27, 226);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(216, 35);
            this.authorTextBox.TabIndex = 1;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextBox.Location = new System.Drawing.Point(27, 310);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(216, 35);
            this.publisherTextBox.TabIndex = 2;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextBox.Location = new System.Drawing.Point(27, 394);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(216, 35);
            this.isbnTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(25, 118);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 21);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(27, 202);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(58, 21);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(24, 285);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(76, 21);
            this.publisherLabel.TabIndex = 6;
            this.publisherLabel.Text = "Publisher";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.Location = new System.Drawing.Point(24, 368);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(60, 21);
            this.isbnLabel.TabIndex = 7;
            this.isbnLabel.Text = "ISBN #";
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.Black;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Location = new System.Drawing.Point(27, 458);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(117, 39);
            this.addBookButton.TabIndex = 8;
            this.addBookButton.Text = "ADD";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(245, 21);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(27, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "GO BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 518);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddBookView";
            this.Text = "Add a Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
    }
}