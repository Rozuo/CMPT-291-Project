using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLTest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand myCommand;

            // testing Roles 
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-I3IEL2R;Initial Catalog=291GroupProject;Integrated Security=True");
            
                SqlDataAdapter sda = new SqlDataAdapter("Select role from Login Where username='" + usrTBox.Text + "' and password='" + passTBox.Text + "'   ", myConnection);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    switch (dt.Rows[0]["Role"] as string)
                    {
                        case "Admin":
                            {
                                this.Hide();
                                LandingPage landingPage = new LandingPage();
                                landingPage.Show();
                                break;
                            }

                        case "Client":
                            {
                                this.Hide();
                                // MenuForm mf = new MenuForm();
                                // mf.Show();
                                MessageBox.Show("This is a Client", "CLIENT");
                                Application.Exit();
                                break;
                            }

                        default:
                            {
                                // ... handle unexpected roles here...
                                break;
                            }
                    }
                }
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Failed to Login", "ERROR");

                    //Application.Exit();
                }
        
          
            /*
            SqlConnection myConnection = new SqlConnection("user id=" + usrTBox.Text + ";" +
                                                            "password=" + passTBox.Text + ";" +
                                                            "server=DESKTOP-I3IEL2R;" +
                                                            "database=291GroupProject; " +
                                                            "connection timeout=30");
                                                            
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                this.Hide();
                LandingPage landingForm = new LandingPage();
                landingForm.ShowDialog();

            }
            catch
            {
                MessageBox.Show("Failed to Login", "ERROR");
                //Application.Exit();
            }
            */
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UsernameText(object sender, EventArgs e)
        {

        }

        private void PasswordText(object sender, EventArgs e)
        {

        }

        private void usrTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                //do stuff
                passTBox.Focus();
            }
        }

        private void passTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // go to next form
            }
            if (e.KeyData == Keys.Tab)
            {
                // switch focus to login button
                LoginButton.Focus();
            }
        }

        private void LoginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                usrTBox.Focus();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
