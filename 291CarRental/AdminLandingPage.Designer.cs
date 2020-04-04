namespace _291CarRental
{
    partial class AdminLandingPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.processRentalButton = new System.Windows.Forms.Button();
            this.processReturnsButton = new System.Windows.Forms.Button();
            this.reportButtons = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(206, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(394, 55);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome Admin";
            // 
            // processRentalButton
            // 
            this.processRentalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.processRentalButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processRentalButton.Location = new System.Drawing.Point(188, 105);
            this.processRentalButton.Name = "processRentalButton";
            this.processRentalButton.Size = new System.Drawing.Size(429, 44);
            this.processRentalButton.TabIndex = 1;
            this.processRentalButton.Text = "Process Rental";
            this.processRentalButton.UseVisualStyleBackColor = false;
            this.processRentalButton.Click += new System.EventHandler(this.processRentalButton_Click);
            // 
            // processReturnsButton
            // 
            this.processReturnsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.processReturnsButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReturnsButton.Location = new System.Drawing.Point(188, 176);
            this.processReturnsButton.Name = "processReturnsButton";
            this.processReturnsButton.Size = new System.Drawing.Size(429, 44);
            this.processReturnsButton.TabIndex = 2;
            this.processReturnsButton.Text = "Process Returns";
            this.processReturnsButton.UseVisualStyleBackColor = false;
            this.processReturnsButton.Click += new System.EventHandler(this.processReturnsButton_Click);
            // 
            // reportButtons
            // 
            this.reportButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reportButtons.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButtons.Location = new System.Drawing.Point(188, 241);
            this.reportButtons.Name = "reportButtons";
            this.reportButtons.Size = new System.Drawing.Size(429, 44);
            this.reportButtons.TabIndex = 3;
            this.reportButtons.Text = "Reports";
            this.reportButtons.UseVisualStyleBackColor = false;
            this.reportButtons.Click += new System.EventHandler(this.reportButtons_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Brown;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(188, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(429, 44);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.Color.Gold;
            this.addVehicleButton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleButton.Location = new System.Drawing.Point(188, 306);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(429, 44);
            this.addVehicleButton.TabIndex = 5;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.reportButtons);
            this.Controls.Add(this.processReturnsButton);
            this.Controls.Add(this.processRentalButton);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLandingPage";
            this.Text = "AdminLandingPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button processRentalButton;
        private System.Windows.Forms.Button processReturnsButton;
        private System.Windows.Forms.Button reportButtons;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button addVehicleButton;
    }
}