namespace LibraryViews
{
    partial class CheckoutBookView
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
            this.checkoutBookButton = new System.Windows.Forms.Button();
            this.getIdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.booksListView = new System.Windows.Forms.ListView();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkoutBookButton
            // 
            this.checkoutBookButton.BackColor = System.Drawing.Color.Black;
            this.checkoutBookButton.FlatAppearance.BorderSize = 0;
            this.checkoutBookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkoutBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBookButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkoutBookButton.ForeColor = System.Drawing.Color.White;
            this.checkoutBookButton.Location = new System.Drawing.Point(23, 445);
            this.checkoutBookButton.Name = "checkoutBookButton";
            this.checkoutBookButton.Size = new System.Drawing.Size(138, 39);
            this.checkoutBookButton.TabIndex = 26;
            this.checkoutBookButton.Text = "CHECKOUT BOOK";
            this.checkoutBookButton.UseVisualStyleBackColor = false;
            this.checkoutBookButton.Click += new System.EventHandler(this.checkoutBookButton_Click);
            // 
            // getIdLabel
            // 
            this.getIdLabel.AutoSize = true;
            this.getIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.getIdLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getIdLabel.Location = new System.Drawing.Point(21, 374);
            this.getIdLabel.Name = "getIdLabel";
            this.getIdLabel.Size = new System.Drawing.Size(65, 21);
            this.getIdLabel.TabIndex = 25;
            this.getIdLabel.Text = "Enter Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(23, 398);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(173, 35);
            this.idTextBox.TabIndex = 24;
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
            this.exitButton.Location = new System.Drawing.Point(470, 14);
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
            this.booksListView.Location = new System.Drawing.Point(25, 68);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(550, 278);
            this.booksListView.TabIndex = 21;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // customerComboBox
            // 
            this.customerComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.IntegralHeight = false;
            this.customerComboBox.Location = new System.Drawing.Point(211, 398);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(195, 29);
            this.customerComboBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Customer";
            // 
            // CheckoutBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.checkoutBookButton);
            this.Controls.Add(this.getIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.booksListView);
            this.Name = "CheckoutBookView";
            this.Text = "CheckoutBookView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkoutBookButton;
        private System.Windows.Forms.Label getIdLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label label1;
    }
}