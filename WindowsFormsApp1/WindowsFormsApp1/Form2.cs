using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Controls.Add(panel1);//add the group box into the form
        }

        private void title_Click(object sender, EventArgs e)
        {

        }


        private void passwordL_Click(object sender, EventArgs e)
        {

        }

        private void cPasswordL_Click(object sender, EventArgs e)
        {

        }

        private void nameL_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Controls.Add(nameL);
            panel1.Controls.Add(passwordL);
            panel1.Controls.Add(cPasswordL);
            panel1.Controls.Add(title);
            panel1.Controls.Add(passwordInput);
            panel1.Controls.Add(passwordConfirm);
            panel1.Controls.Add(usernameInput);
            panel1.Controls.Add(confirmB);
            panel1.Controls.Add(backB);
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmB_Click(object sender, EventArgs e)
        {
            if (passwordInput.Text != passwordConfirm.Text)
            {
                MessageBox.Show("Your password and confirm password are different!");
            }
            else if(passwordInput.Text.Length == 0 || usernameInput.Text.Length == 0){
                MessageBox.Show("Username or password cannot be empty!");
            }
            else
            {
                string content = "Your username is " + usernameInput.Text +
                    "\nYour password is " + passwordInput.Text;
                MessageBox.Show(content);
                string closeMessage = "Do you want to close the window?";
                string title = "Close window";
                MessageBoxButtons closeBox = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(closeMessage, title, closeBox);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void backB_Click(object sender, EventArgs e)
        {
            string closeMessage = "Are you sure to go back?";
            string title = "Warning";
            MessageBoxButtons closeBox = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(closeMessage, title, closeBox);
            if(result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }
    }
}
