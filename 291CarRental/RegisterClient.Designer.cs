namespace _291CarRental
{
    partial class RegisterClient
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.RegisterClientLabel = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Phone1 = new System.Windows.Forms.TextBox();
            this.Phone2 = new System.Windows.Forms.TextBox();
            this.Phone3 = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.TextBox();
            this.dash1 = new System.Windows.Forms.Label();
            this.dash2 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.topPanel.Controls.Add(this.RegisterClientLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(733, 100);
            this.topPanel.TabIndex = 0;
            // 
            // RegisterClientLabel
            // 
            this.RegisterClientLabel.AutoSize = true;
            this.RegisterClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterClientLabel.Location = new System.Drawing.Point(97, 22);
            this.RegisterClientLabel.Name = "RegisterClientLabel";
            this.RegisterClientLabel.Size = new System.Drawing.Size(468, 55);
            this.RegisterClientLabel.TabIndex = 0;
            this.RegisterClientLabel.Text = "REGISTER CLIENT";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FirstName.Location = new System.Drawing.Point(26, 133);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(301, 51);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LastName.Location = new System.Drawing.Point(344, 133);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(365, 51);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            // 
            // Address
            // 
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Address.Location = new System.Drawing.Point(26, 210);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(683, 49);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // Phone1
            // 
            this.Phone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Phone1.Location = new System.Drawing.Point(26, 285);
            this.Phone1.MaxLength = 3;
            this.Phone1.Multiline = true;
            this.Phone1.Name = "Phone1";
            this.Phone1.Size = new System.Drawing.Size(98, 49);
            this.Phone1.TabIndex = 4;
            this.Phone1.Text = "780";
            this.Phone1.TextChanged += new System.EventHandler(this.Phone1_TextChanged);
            // 
            // Phone2
            // 
            this.Phone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Phone2.Location = new System.Drawing.Point(166, 285);
            this.Phone2.MaxLength = 3;
            this.Phone2.Multiline = true;
            this.Phone2.Name = "Phone2";
            this.Phone2.Size = new System.Drawing.Size(113, 49);
            this.Phone2.TabIndex = 5;
            this.Phone2.Text = "???";
            this.Phone2.TextChanged += new System.EventHandler(this.Phone2_TextChanged);
            // 
            // Phone3
            // 
            this.Phone3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Phone3.Location = new System.Drawing.Point(319, 285);
            this.Phone3.MaxLength = 4;
            this.Phone3.Multiline = true;
            this.Phone3.Name = "Phone3";
            this.Phone3.Size = new System.Drawing.Size(119, 49);
            this.Phone3.TabIndex = 6;
            this.Phone3.Text = "????";
            this.Phone3.TextChanged += new System.EventHandler(this.Phone3_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DarkRed;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.registerButton.Location = new System.Drawing.Point(26, 603);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(683, 60);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.username.Location = new System.Drawing.Point(26, 351);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(683, 49);
            this.username.TabIndex = 8;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(26, 418);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(683, 49);
            this.password.TabIndex = 9;
            this.password.Text = "something";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.confirmLabel.Location = new System.Drawing.Point(32, 487);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(312, 39);
            this.confirmLabel.TabIndex = 10;
            this.confirmLabel.Text = "Confirm Password:";
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.confirm.Location = new System.Drawing.Point(26, 535);
            this.confirm.Multiline = true;
            this.confirm.Name = "confirm";
            this.confirm.PasswordChar = '•';
            this.confirm.Size = new System.Drawing.Size(683, 49);
            this.confirm.TabIndex = 11;
            this.confirm.Text = "something";
            // 
            // dash1
            // 
            this.dash1.AutoSize = true;
            this.dash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash1.ForeColor = System.Drawing.SystemColors.Control;
            this.dash1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dash1.Location = new System.Drawing.Point(129, 288);
            this.dash1.Name = "dash1";
            this.dash1.Size = new System.Drawing.Size(31, 42);
            this.dash1.TabIndex = 12;
            this.dash1.Text = "-";
            // 
            // dash2
            // 
            this.dash2.AutoSize = true;
            this.dash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash2.ForeColor = System.Drawing.SystemColors.Control;
            this.dash2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dash2.Location = new System.Drawing.Point(285, 288);
            this.dash2.Name = "dash2";
            this.dash2.Size = new System.Drawing.Size(31, 42);
            this.dash2.TabIndex = 13;
            this.dash2.Text = "-";
            // 
            // RegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(733, 688);
            this.Controls.Add(this.dash2);
            this.Controls.Add(this.dash1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.Phone3);
            this.Controls.Add(this.Phone2);
            this.Controls.Add(this.Phone1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "RegisterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterClient";
            this.Load += new System.EventHandler(this.RegisterClient_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label RegisterClientLabel;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Phone1;
        private System.Windows.Forms.TextBox Phone2;
        private System.Windows.Forms.TextBox Phone3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.Label dash1;
        private System.Windows.Forms.Label dash2;
    }
}