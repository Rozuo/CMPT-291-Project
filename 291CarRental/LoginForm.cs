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

/* 291 Car Rental Project Client and Admin Pages
 * Alex Creencia, March 26, 2020
 * 
 * This car rental project is a part of the 291 group project that allows a user of these forms to simulate an admin or client
 * 
 * To test from the client side, the username is "User2", and password is "test"
 * To test from the admin side, the username is "User1", and password is "pass"
 * 
 * Of course, this is assuming you have these two records within your local database, otherwise you can use your own to test with your local database.
 * If you are testing with your own local database, please go to database.cs and change the connection string to YOUR database in order to have this functional.
 * 
 */

namespace _291CarRental
{
    public partial class loginForm : Form
    {
        public database datab;
        public loginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*
             * datab will have all the necessary information for the connection, what it does not handle is user input for either query commands or inserting
             */
            
            try
            {
                datab = new database(username.Text);
                
                /*
                 * The following parameter block denies SQL injection, by splitting the input into parameters, which will account for random apostrophes '
                 */
                datab.myCommand.CommandText = "Select role from Login Where username=@User " + "and password=@Pass;";
                datab.myCommand.Parameters.AddWithValue("User", username.Text);
                datab.myCommand.Parameters.AddWithValue("Pass", password.Text);


                SqlDataAdapter sda = new SqlDataAdapter(datab.myCommand);
                //SqlDataAdapter sda = new SqlDataAdapter("Select role from Login Where username='" + username.Text + "' and password='" + password.Text + "'   ", datab.myConnection);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    switch (dt.Rows[0]["Role"] as string)
                    {
                        /*
                         * This switch statement controls which forms are shown to the user depending on whether their role in the database is a "Client" or an "Admin". There is a default
                         * case included just in case an unexpected role is encountered.
                         */
                        case "Admin":
                            {
                                /*
                                 * Admin form flow handled here
                                 */
                                this.Hide();
                                MessageBox.Show("This is an Admin", "ADMIN");
                                break;
                            }

                        case "Client":
                            {
                                /*
                                 * Client form flow handled here
                                 */
                                this.Hide();
                                clientLandingPage CLP = new clientLandingPage();
                                CLP.ShowDialog();
                                Application.Exit();
                                break;
                            }

                        default:
                            {
                                // ... handle unexpected roles here..
                                MessageBox.Show("EXCEPTION: Role is neither 'Client' or 'Admin'. This is either a new Role, or an Error altogether", "EXCEPTION");
                                break;
                            }
                    }
                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Failed to Login", "ERROR");

                    //Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("An error has been encountered. Please try again", "ERROR");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            datab = new database();
            RegisterClient registerForm = new RegisterClient(datab);
            registerForm.ShowDialog();
        }
    }
}
