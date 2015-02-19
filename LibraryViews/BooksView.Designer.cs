namespace LibraryViews
{
    partial class BooksView
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
            this.addBookButton = new System.Windows.Forms.Button();
            this.booksListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.Black;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Location = new System.Drawing.Point(694, 575);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(117, 39);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "ADD BOOK";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // booksListView
            // 
            this.booksListView.Location = new System.Drawing.Point(12, 12);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(649, 602);
            this.booksListView.TabIndex = 2;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // BooksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 639);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.addBookButton);
            this.Name = "BooksView";
            this.Text = "Books";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.ListView booksListView;
    }
}