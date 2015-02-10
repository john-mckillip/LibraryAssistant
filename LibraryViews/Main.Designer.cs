namespace LibraryViews
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryViews.Properties.Resources.book_icon;
            this.pictureBox1.Location = new System.Drawing.Point(466, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryViews.Properties.Resources.customers_icon;
            this.pictureBox2.Location = new System.Drawing.Point(788, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.Color.Black;
            this.booksButton.FlatAppearance.BorderSize = 0;
            this.booksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.ForeColor = System.Drawing.Color.White;
            this.booksButton.Location = new System.Drawing.Point(480, 455);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(117, 39);
            this.booksButton.TabIndex = 2;
            this.booksButton.Text = "BOOKS";
            this.booksButton.UseVisualStyleBackColor = false;
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.Black;
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.ForeColor = System.Drawing.Color.White;
            this.customersButton.Location = new System.Drawing.Point(804, 455);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(117, 39);
            this.customersButton.TabIndex = 3;
            this.customersButton.Text = "CUSTOMERS";
            this.customersButton.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 644);
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
    }
}

