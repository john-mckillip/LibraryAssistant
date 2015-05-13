namespace LibraryViews
{
    partial class CheckInDvdView
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
            this.checkInDvdButton = new System.Windows.Forms.Button();
            this.getIdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mediaListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // checkInDvdButton
            // 
            this.checkInDvdButton.BackColor = System.Drawing.Color.Black;
            this.checkInDvdButton.FlatAppearance.BorderSize = 0;
            this.checkInDvdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkInDvdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInDvdButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkInDvdButton.ForeColor = System.Drawing.Color.White;
            this.checkInDvdButton.Location = new System.Drawing.Point(29, 469);
            this.checkInDvdButton.Name = "checkInDvdButton";
            this.checkInDvdButton.Size = new System.Drawing.Size(138, 39);
            this.checkInDvdButton.TabIndex = 46;
            this.checkInDvdButton.Text = "CHECK IN DVD";
            this.checkInDvdButton.UseVisualStyleBackColor = false;
            this.checkInDvdButton.Click += new System.EventHandler(this.checkInDvdButton_Click);
            // 
            // getIdLabel
            // 
            this.getIdLabel.AutoSize = true;
            this.getIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.getIdLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getIdLabel.Location = new System.Drawing.Point(27, 398);
            this.getIdLabel.Name = "getIdLabel";
            this.getIdLabel.Size = new System.Drawing.Size(65, 21);
            this.getIdLabel.TabIndex = 45;
            this.getIdLabel.Text = "Enter Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(29, 422);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(173, 35);
            this.idTextBox.TabIndex = 44;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(31, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 43;
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
            this.exitButton.Location = new System.Drawing.Point(548, 38);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 42;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mediaListView
            // 
            this.mediaListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mediaListView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaListView.ForeColor = System.Drawing.Color.Black;
            this.mediaListView.Location = new System.Drawing.Point(31, 92);
            this.mediaListView.Name = "mediaListView";
            this.mediaListView.Size = new System.Drawing.Size(622, 278);
            this.mediaListView.TabIndex = 41;
            this.mediaListView.UseCompatibleStateImageBehavior = false;
            this.mediaListView.View = System.Windows.Forms.View.Details;
            // 
            // CheckInDvdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 546);
            this.Controls.Add(this.checkInDvdButton);
            this.Controls.Add(this.getIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mediaListView);
            this.Name = "CheckInDvdView";
            this.Text = "CheckInDvdView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkInDvdButton;
        private System.Windows.Forms.Label getIdLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView mediaListView;
    }
}