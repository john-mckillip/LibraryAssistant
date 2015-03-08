namespace LibraryViews
{
    partial class CustomersView
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
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.customersListView = new System.Windows.Forms.ListView();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.BackColor = System.Drawing.Color.Black;
            this.editCustomerButton.FlatAppearance.BorderSize = 0;
            this.editCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomerButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCustomerButton.ForeColor = System.Drawing.Color.White;
            this.editCustomerButton.Location = new System.Drawing.Point(25, 524);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(550, 46);
            this.editCustomerButton.TabIndex = 13;
            this.editCustomerButton.Text = "EDIT CUSTOMERS";
            this.editCustomerButton.UseVisualStyleBackColor = false;
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Black;
            this.checkoutButton.FlatAppearance.BorderSize = 0;
            this.checkoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkoutButton.ForeColor = System.Drawing.Color.White;
            this.checkoutButton.Location = new System.Drawing.Point(25, 584);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(0, 0);
            this.checkoutButton.TabIndex = 12;
            this.checkoutButton.Text = "CHECK OUT BOOK";
            this.checkoutButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(25, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 11;
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
            this.exitButton.Location = new System.Drawing.Point(470, 17);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 40);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customersListView
            // 
            this.customersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersListView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersListView.ForeColor = System.Drawing.Color.Black;
            this.customersListView.Location = new System.Drawing.Point(25, 63);
            this.customersListView.Name = "customersListView";
            this.customersListView.Size = new System.Drawing.Size(550, 371);
            this.customersListView.TabIndex = 9;
            this.customersListView.UseCompatibleStateImageBehavior = false;
            this.customersListView.View = System.Windows.Forms.View.Details;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.Black;
            this.addCustomerButton.FlatAppearance.BorderSize = 0;
            this.addCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.ForeColor = System.Drawing.Color.White;
            this.addCustomerButton.Location = new System.Drawing.Point(25, 463);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(550, 46);
            this.addCustomerButton.TabIndex = 8;
            this.addCustomerButton.Text = "ADD CUSTOMER";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 605);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customersListView);
            this.Controls.Add(this.addCustomerButton);
            this.Name = "CustomersView";
            this.Text = "Customers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView customersListView;
        private System.Windows.Forms.Button addCustomerButton;
    }
}