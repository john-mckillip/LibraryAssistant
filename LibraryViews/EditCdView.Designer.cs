namespace LibraryViews
{
    partial class EditCdView
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
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mediaListView = new System.Windows.Forms.ListView();
            this.deleteCDButton = new System.Windows.Forms.Button();
            this.updateCdButton = new System.Windows.Forms.Button();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.performerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.producerTextBox = new System.Windows.Forms.TextBox();
            this.performerTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.getCdButton = new System.Windows.Forms.Button();
            this.getIdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(24, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 14;
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
            this.exitButton.Location = new System.Drawing.Point(553, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mediaListView
            // 
            this.mediaListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mediaListView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaListView.ForeColor = System.Drawing.Color.Black;
            this.mediaListView.Location = new System.Drawing.Point(24, 58);
            this.mediaListView.Name = "mediaListView";
            this.mediaListView.Size = new System.Drawing.Size(634, 310);
            this.mediaListView.TabIndex = 12;
            this.mediaListView.UseCompatibleStateImageBehavior = false;
            this.mediaListView.View = System.Windows.Forms.View.Details;
            // 
            // deleteCDButton
            // 
            this.deleteCDButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteCDButton.FlatAppearance.BorderSize = 0;
            this.deleteCDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteCDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCDButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.deleteCDButton.ForeColor = System.Drawing.Color.White;
            this.deleteCDButton.Location = new System.Drawing.Point(22, 516);
            this.deleteCDButton.Name = "deleteCDButton";
            this.deleteCDButton.Size = new System.Drawing.Size(117, 39);
            this.deleteCDButton.TabIndex = 33;
            this.deleteCDButton.Text = "DELETE CD";
            this.deleteCDButton.UseVisualStyleBackColor = false;
            this.deleteCDButton.Click += new System.EventHandler(this.deleteCDButton_Click);
            // 
            // updateCdButton
            // 
            this.updateCdButton.BackColor = System.Drawing.Color.Black;
            this.updateCdButton.FlatAppearance.BorderSize = 0;
            this.updateCdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateCdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCdButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.updateCdButton.ForeColor = System.Drawing.Color.White;
            this.updateCdButton.Location = new System.Drawing.Point(369, 672);
            this.updateCdButton.Name = "updateCdButton";
            this.updateCdButton.Size = new System.Drawing.Size(117, 39);
            this.updateCdButton.TabIndex = 32;
            this.updateCdButton.Text = "UPDATE CD";
            this.updateCdButton.UseVisualStyleBackColor = false;
            this.updateCdButton.Click += new System.EventHandler(this.updateCdButton_Click);
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(366, 595);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(76, 21);
            this.publisherLabel.TabIndex = 31;
            this.publisherLabel.Text = "Publisher";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerLabel.Location = new System.Drawing.Point(366, 520);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(74, 21);
            this.producerLabel.TabIndex = 30;
            this.producerLabel.Text = "Producer";
            // 
            // performerLabel
            // 
            this.performerLabel.AutoSize = true;
            this.performerLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performerLabel.Location = new System.Drawing.Point(369, 453);
            this.performerLabel.Name = "performerLabel";
            this.performerLabel.Size = new System.Drawing.Size(80, 21);
            this.performerLabel.TabIndex = 29;
            this.performerLabel.Text = "Performer";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(367, 387);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 21);
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Title";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextBox.Location = new System.Drawing.Point(369, 621);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(290, 35);
            this.publisherTextBox.TabIndex = 27;
            // 
            // producerTextBox
            // 
            this.producerTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerTextBox.Location = new System.Drawing.Point(369, 545);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(290, 35);
            this.producerTextBox.TabIndex = 26;
            // 
            // performerTextBox
            // 
            this.performerTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performerTextBox.Location = new System.Drawing.Point(369, 477);
            this.performerTextBox.Name = "performerTextBox";
            this.performerTextBox.Size = new System.Drawing.Size(290, 35);
            this.performerTextBox.TabIndex = 25;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(369, 411);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(290, 35);
            this.titleTextBox.TabIndex = 24;
            // 
            // getCdButton
            // 
            this.getCdButton.BackColor = System.Drawing.Color.Black;
            this.getCdButton.FlatAppearance.BorderSize = 0;
            this.getCdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.getCdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCdButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.getCdButton.ForeColor = System.Drawing.Color.White;
            this.getCdButton.Location = new System.Drawing.Point(22, 463);
            this.getCdButton.Name = "getCdButton";
            this.getCdButton.Size = new System.Drawing.Size(117, 39);
            this.getCdButton.TabIndex = 23;
            this.getCdButton.Text = "GET CD";
            this.getCdButton.UseVisualStyleBackColor = false;
            this.getCdButton.Click += new System.EventHandler(this.getCdButton_Click);
            // 
            // getIdLabel
            // 
            this.getIdLabel.AutoSize = true;
            this.getIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.getIdLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getIdLabel.Location = new System.Drawing.Point(20, 392);
            this.getIdLabel.Name = "getIdLabel";
            this.getIdLabel.Size = new System.Drawing.Size(65, 21);
            this.getIdLabel.TabIndex = 22;
            this.getIdLabel.Text = "Enter Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(22, 416);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(173, 35);
            this.idTextBox.TabIndex = 21;
            // 
            // EditCdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 741);
            this.Controls.Add(this.deleteCDButton);
            this.Controls.Add(this.updateCdButton);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.performerLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.performerTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.getCdButton);
            this.Controls.Add(this.getIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mediaListView);
            this.Name = "EditCdView";
            this.Text = "EditCdView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView mediaListView;
        private System.Windows.Forms.Button deleteCDButton;
        private System.Windows.Forms.Button updateCdButton;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label performerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox producerTextBox;
        private System.Windows.Forms.TextBox performerTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button getCdButton;
        private System.Windows.Forms.Label getIdLabel;
        private System.Windows.Forms.TextBox idTextBox;
    }
}