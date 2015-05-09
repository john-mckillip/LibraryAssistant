namespace LibraryViews
{
    partial class CheckoutCdView
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.checkoutCdButton = new System.Windows.Forms.Button();
            this.getIdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mediaListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Customer";
            // 
            // customerComboBox
            // 
            this.customerComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.IntegralHeight = false;
            this.customerComboBox.Location = new System.Drawing.Point(214, 422);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(195, 29);
            this.customerComboBox.TabIndex = 35;
            // 
            // checkoutCdButton
            // 
            this.checkoutCdButton.BackColor = System.Drawing.Color.Black;
            this.checkoutCdButton.FlatAppearance.BorderSize = 0;
            this.checkoutCdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkoutCdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutCdButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkoutCdButton.ForeColor = System.Drawing.Color.White;
            this.checkoutCdButton.Location = new System.Drawing.Point(26, 469);
            this.checkoutCdButton.Name = "checkoutCdButton";
            this.checkoutCdButton.Size = new System.Drawing.Size(138, 39);
            this.checkoutCdButton.TabIndex = 34;
            this.checkoutCdButton.Text = "CHECKOUT CD";
            this.checkoutCdButton.UseVisualStyleBackColor = false;
            this.checkoutCdButton.Click += new System.EventHandler(this.checkoutCdButton_Click);
            // 
            // getIdLabel
            // 
            this.getIdLabel.AutoSize = true;
            this.getIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.getIdLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getIdLabel.Location = new System.Drawing.Point(24, 398);
            this.getIdLabel.Name = "getIdLabel";
            this.getIdLabel.Size = new System.Drawing.Size(65, 21);
            this.getIdLabel.TabIndex = 33;
            this.getIdLabel.Text = "Enter Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(26, 422);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(173, 35);
            this.idTextBox.TabIndex = 32;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(28, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 31;
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
            this.exitButton.Location = new System.Drawing.Point(552, 38);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 30;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mediaListView
            // 
            this.mediaListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mediaListView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaListView.ForeColor = System.Drawing.Color.Black;
            this.mediaListView.Location = new System.Drawing.Point(28, 92);
            this.mediaListView.Name = "mediaListView";
            this.mediaListView.Size = new System.Drawing.Size(629, 278);
            this.mediaListView.TabIndex = 29;
            this.mediaListView.UseCompatibleStateImageBehavior = false;
            this.mediaListView.View = System.Windows.Forms.View.Details;
            // 
            // CheckoutCdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.checkoutCdButton);
            this.Controls.Add(this.getIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mediaListView);
            this.Name = "CheckoutCdView";
            this.Text = "CheckoutCdView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button checkoutCdButton;
        private System.Windows.Forms.Label getIdLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView mediaListView;
    }
}