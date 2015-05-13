namespace LibraryViews
{
    partial class AddDvdView
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
            this.addDvdButton = new System.Windows.Forms.Button();
            this.starLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.starTextBox = new System.Windows.Forms.TextBox();
            this.producerTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.backButton.Location = new System.Drawing.Point(30, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 33;
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
            this.exitButton.Location = new System.Drawing.Point(248, 21);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 32;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addDvdButton
            // 
            this.addDvdButton.BackColor = System.Drawing.Color.Black;
            this.addDvdButton.FlatAppearance.BorderSize = 0;
            this.addDvdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addDvdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDvdButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.addDvdButton.ForeColor = System.Drawing.Color.White;
            this.addDvdButton.Location = new System.Drawing.Point(30, 458);
            this.addDvdButton.Name = "addDvdButton";
            this.addDvdButton.Size = new System.Drawing.Size(117, 39);
            this.addDvdButton.TabIndex = 31;
            this.addDvdButton.Text = "ADD";
            this.addDvdButton.UseVisualStyleBackColor = false;
            this.addDvdButton.Click += new System.EventHandler(this.addDvdButton_Click);
            // 
            // starLabel
            // 
            this.starLabel.AutoSize = true;
            this.starLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starLabel.Location = new System.Drawing.Point(27, 368);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(62, 21);
            this.starLabel.TabIndex = 30;
            this.starLabel.Text = "Staring";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerLabel.Location = new System.Drawing.Point(27, 285);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(74, 21);
            this.producerLabel.TabIndex = 29;
            this.producerLabel.Text = "Producer";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorLabel.Location = new System.Drawing.Point(30, 202);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(67, 21);
            this.directorLabel.TabIndex = 28;
            this.directorLabel.Text = "Director";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(28, 118);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 21);
            this.titleLabel.TabIndex = 27;
            this.titleLabel.Text = "Title";
            // 
            // starTextBox
            // 
            this.starTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starTextBox.Location = new System.Drawing.Point(30, 394);
            this.starTextBox.Name = "starTextBox";
            this.starTextBox.Size = new System.Drawing.Size(216, 35);
            this.starTextBox.TabIndex = 26;
            // 
            // producerTextBox
            // 
            this.producerTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerTextBox.Location = new System.Drawing.Point(30, 310);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(216, 35);
            this.producerTextBox.TabIndex = 25;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorTextBox.Location = new System.Drawing.Point(30, 226);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(216, 35);
            this.directorTextBox.TabIndex = 24;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(30, 142);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(216, 35);
            this.titleTextBox.TabIndex = 23;
            // 
            // AddDvdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 518);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addDvdButton);
            this.Controls.Add(this.starLabel);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.starTextBox);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddDvdView";
            this.Text = "AddDvdView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addDvdButton;
        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox starTextBox;
        private System.Windows.Forms.TextBox producerTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}