using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string message = "Do you want to close the window?";
            string title = "Close window";
            MessageBox.Show("name: " + name +"\n password: " + password);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);//format is message, title, then button
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "You selected "+comboBox1.GetItemText(comboBox1.SelectedItem);
            MessageBox.Show(text, "Donation");
        }

        private void signUpB_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();
            this.Hide();
            registerForm.ShowDialog();
        }

        private void connectB_Click(object sender, EventArgs e)
        {
            string connectString;
            SqlConnection cnn;
            connectString = @"Data Source=DESKTOP-9JM8HEJ;Initial Catalog=291GroupProject;
User ID="+textBox1.Text+";Password="+textBox2.Text;
            try
            {
                cnn = new SqlConnection(connectString);
                cnn.Open();
                MessageBox.Show("Open!");
                cnn.Close();
            }
            catch{
                MessageBox.Show("No user exist or wrong password !");
            }
        }

        private void reservationB_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            this.Hide();
            reservation.ShowDialog();
        }
    }
}
