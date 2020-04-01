namespace WindowsFormsApp1
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.donaitonMoney = new System.Windows.Forms.Label();
            this.signUpB = new System.Windows.Forms.Button();
            this.connectB = new System.Windows.Forms.Button();
            this.reservationB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Red;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(63, 63);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 46);
            this.name.TabIndex = 0;
            this.name.Text = "Name: ";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Indigo;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(34, 141);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 46);
            this.password.TabIndex = 1;
            this.password.Text = "Password: ";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(287, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(287, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 53);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(370, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "$10<",
            "$10 - $50",
            "$50 - $100",
            "$100 - $200",
            "$200 >"});
            this.comboBox1.Location = new System.Drawing.Point(241, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // donaitonMoney
            // 
            this.donaitonMoney.AutoSize = true;
            this.donaitonMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donaitonMoney.Location = new System.Drawing.Point(90, 237);
            this.donaitonMoney.Name = "donaitonMoney";
            this.donaitonMoney.Size = new System.Drawing.Size(90, 25);
            this.donaitonMoney.TabIndex = 7;
            this.donaitonMoney.Text = "Donation";
            // 
            // signUpB
            // 
            this.signUpB.BackColor = System.Drawing.Color.Plum;
            this.signUpB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpB.Location = new System.Drawing.Point(596, 60);
            this.signUpB.Name = "signUpB";
            this.signUpB.Size = new System.Drawing.Size(158, 46);
            this.signUpB.TabIndex = 8;
            this.signUpB.Text = "Sign up";
            this.signUpB.UseVisualStyleBackColor = false;
            this.signUpB.Click += new System.EventHandler(this.signUpB_Click);
            // 
            // connectB
            // 
            this.connectB.BackColor = System.Drawing.Color.Teal;
            this.connectB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectB.Location = new System.Drawing.Point(460, 322);
            this.connectB.Name = "connectB";
            this.connectB.Size = new System.Drawing.Size(94, 34);
            this.connectB.TabIndex = 9;
            this.connectB.Text = "Sign in";
            this.connectB.UseVisualStyleBackColor = false;
            this.connectB.Click += new System.EventHandler(this.connectB_Click);
            // 
            // reservationB
            // 
            this.reservationB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reservationB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reservationB.Location = new System.Drawing.Point(232, 323);
            this.reservationB.Name = "reservationB";
            this.reservationB.Size = new System.Drawing.Size(121, 35);
            this.reservationB.TabIndex = 10;
            this.reservationB.Text = "Reservation";
            this.reservationB.UseVisualStyleBackColor = false;
            this.reservationB.Click += new System.EventHandler(this.reservationB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reservationB);
            this.Controls.Add(this.connectB);
            this.Controls.Add(this.signUpB);
            this.Controls.Add(this.donaitonMoney);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label donaitonMoney;
        private System.Windows.Forms.Button signUpB;
        private System.Windows.Forms.Button connectB;
        private System.Windows.Forms.Button reservationB;
    }
}

