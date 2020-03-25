namespace SQLTest
{
    partial class LandingPage
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
            this.clientsButton = new System.Windows.Forms.Button();
            this.carsButton = new System.Windows.Forms.Button();
            this.reservationButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.landingText = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.clientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.clientsButton.Location = new System.Drawing.Point(31, 136);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(320, 84);
            this.clientsButton.TabIndex = 0;
            this.clientsButton.Text = "View/Insert Clients";
            this.clientsButton.UseVisualStyleBackColor = false;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // carsButton
            // 
            this.carsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.carsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carsButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.carsButton.Location = new System.Drawing.Point(31, 269);
            this.carsButton.Name = "carsButton";
            this.carsButton.Size = new System.Drawing.Size(320, 84);
            this.carsButton.TabIndex = 1;
            this.carsButton.Text = "View/Register Cars";
            this.carsButton.UseVisualStyleBackColor = false;
            // 
            // reservationButton
            // 
            this.reservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.reservationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.reservationButton.Location = new System.Drawing.Point(407, 136);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(320, 84);
            this.reservationButton.TabIndex = 2;
            this.reservationButton.Text = "View Reservations";
            this.reservationButton.UseVisualStyleBackColor = false;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.returnButton.Location = new System.Drawing.Point(407, 269);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(320, 84);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return Vehicle";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.landingText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 4;
            // 
            // landingText
            // 
            this.landingText.AutoSize = true;
            this.landingText.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.landingText.Location = new System.Drawing.Point(202, 18);
            this.landingText.Name = "landingText";
            this.landingText.Size = new System.Drawing.Size(334, 57);
            this.landingText.TabIndex = 0;
            this.landingText.Text = "Landing Page";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Brown;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(291, 382);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 56);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.carsButton);
            this.Controls.Add(this.clientsButton);
            this.Name = "LandingPage";
            this.Text = "Register Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button carsButton;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label landingText;
        private System.Windows.Forms.Button exitButton;
    }
}