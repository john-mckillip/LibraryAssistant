﻿namespace LibraryViews
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.booksButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cdButton = new System.Windows.Forms.Button();
            this.dvdButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryViews.Properties.Resources.book_icon;
            this.pictureBox1.Location = new System.Drawing.Point(34, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryViews.Properties.Resources.customers_icon;
            this.pictureBox2.Location = new System.Drawing.Point(126, 522);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 117);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.Color.Black;
            this.booksButton.FlatAppearance.BorderSize = 0;
            this.booksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.booksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.ForeColor = System.Drawing.Color.White;
            this.booksButton.Location = new System.Drawing.Point(48, 230);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(117, 39);
            this.booksButton.TabIndex = 2;
            this.booksButton.Text = "BOOKS";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.Black;
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.ForeColor = System.Drawing.Color.White;
            this.customersButton.Location = new System.Drawing.Point(142, 659);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(117, 39);
            this.customersButton.TabIndex = 3;
            this.customersButton.Text = "CUSTOMERS";
            this.customersButton.UseVisualStyleBackColor = false;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(369, 28);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cdButton
            // 
            this.cdButton.BackColor = System.Drawing.Color.Black;
            this.cdButton.FlatAppearance.BorderSize = 0;
            this.cdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdButton.ForeColor = System.Drawing.Color.White;
            this.cdButton.Location = new System.Drawing.Point(247, 230);
            this.cdButton.Name = "cdButton";
            this.cdButton.Size = new System.Drawing.Size(117, 39);
            this.cdButton.TabIndex = 5;
            this.cdButton.Text = "CDS";
            this.cdButton.UseVisualStyleBackColor = false;
            // 
            // dvdButton
            // 
            this.dvdButton.BackColor = System.Drawing.Color.Black;
            this.dvdButton.FlatAppearance.BorderSize = 0;
            this.dvdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dvdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dvdButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvdButton.ForeColor = System.Drawing.Color.White;
            this.dvdButton.Location = new System.Drawing.Point(46, 433);
            this.dvdButton.Name = "dvdButton";
            this.dvdButton.Size = new System.Drawing.Size(117, 39);
            this.dvdButton.TabIndex = 6;
            this.dvdButton.Text = "DVDS";
            this.dvdButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(247, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "GAMES";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvdButton);
            this.Controls.Add(this.cdButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Library Assistant 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cdButton;
        private System.Windows.Forms.Button dvdButton;
        private System.Windows.Forms.Button button1;
    }
}

