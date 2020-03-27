namespace _291CarRental
{
    partial class clientLandingPage
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
            this.checkCarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.currentRentalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkCarButton
            // 
            this.checkCarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkCarButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCarButton.Location = new System.Drawing.Point(31, 115);
            this.checkCarButton.Name = "checkCarButton";
            this.checkCarButton.Size = new System.Drawing.Size(470, 85);
            this.checkCarButton.TabIndex = 0;
            this.checkCarButton.Text = "Rent a Vehicle";
            this.checkCarButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 100);
            this.panel1.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 21);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(547, 57);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Car Rentals";
            // 
            // currentRentalButton
            // 
            this.currentRentalButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.currentRentalButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRentalButton.Location = new System.Drawing.Point(31, 227);
            this.currentRentalButton.Name = "currentRentalButton";
            this.currentRentalButton.Size = new System.Drawing.Size(470, 85);
            this.currentRentalButton.TabIndex = 2;
            this.currentRentalButton.Text = "View Current Rental";
            this.currentRentalButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Brown;
            this.exitButton.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(31, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(470, 71);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.profileButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.Location = new System.Drawing.Point(31, 333);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(470, 85);
            this.profileButton.TabIndex = 4;
            this.profileButton.Text = "View Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            // 
            // clientLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(560, 547);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.currentRentalButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkCarButton);
            this.Name = "clientLandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "clientLandingPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkCarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button currentRentalButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button profileButton;
    }
}