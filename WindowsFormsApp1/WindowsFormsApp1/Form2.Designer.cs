namespace WindowsFormsApp1
{
    partial class Form2
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
            this.title = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.cPasswordL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.backB = new System.Windows.Forms.Button();
            this.confirmB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.title.Location = new System.Drawing.Point(315, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(155, 46);
            this.title.TabIndex = 0;
            this.title.Text = "Sign up";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameL.Location = new System.Drawing.Point(145, 117);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(142, 31);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "username:";
            this.nameL.Click += new System.EventHandler(this.nameL_Click);
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordL.Location = new System.Drawing.Point(155, 166);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(139, 31);
            this.passwordL.TabIndex = 2;
            this.passwordL.Text = "password:";
            this.passwordL.Click += new System.EventHandler(this.passwordL_Click);
            // 
            // cPasswordL
            // 
            this.cPasswordL.AutoSize = true;
            this.cPasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPasswordL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cPasswordL.Location = new System.Drawing.Point(59, 219);
            this.cPasswordL.Name = "cPasswordL";
            this.cPasswordL.Size = new System.Drawing.Size(235, 31);
            this.cPasswordL.TabIndex = 3;
            this.cPasswordL.Text = "confirm password:";
            this.cPasswordL.Click += new System.EventHandler(this.cPasswordL_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cPasswordL);
            this.panel1.Controls.Add(this.confirmB);
            this.panel1.Controls.Add(this.passwordL);
            this.panel1.Controls.Add(this.nameL);
            this.panel1.Controls.Add(this.backB);
            this.panel1.Controls.Add(this.passwordInput);
            this.panel1.Controls.Add(this.passwordConfirm);
            this.panel1.Controls.Add(this.usernameInput);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(300, 114);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(173, 38);
            this.usernameInput.TabIndex = 0;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfirm.Location = new System.Drawing.Point(300, 219);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(173, 38);
            this.passwordConfirm.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(300, 166);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(173, 38);
            this.passwordInput.TabIndex = 2;
            // 
            // backB
            // 
            this.backB.BackColor = System.Drawing.Color.Red;
            this.backB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.Location = new System.Drawing.Point(161, 311);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(106, 39);
            this.backB.TabIndex = 3;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = false;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // confirmB
            // 
            this.confirmB.BackColor = System.Drawing.Color.Lime;
            this.confirmB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmB.Location = new System.Drawing.Point(427, 311);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(124, 39);
            this.confirmB.TabIndex = 4;
            this.confirmB.Text = "Confirm";
            this.confirmB.UseVisualStyleBackColor = false;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label cPasswordL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Button backB;
    }
}