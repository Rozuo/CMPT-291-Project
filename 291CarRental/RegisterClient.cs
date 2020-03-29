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
namespace _291CarRental
{
    public partial class RegisterClient : Form
    {
        public database datab;
        public RegisterClient(database temp)
        {
            InitializeComponent();
            datab = temp;
        }

        private void Phone3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            int errorFlag = 0;
            Guid ClientID = Guid.NewGuid();
            string Phone = Phone1.Text + Phone2.Text + Phone3.Text;
            database account = datab;
            try
            {
                /*
                 * Insert into Login table starts here. We need to insert into login table first, as the username is a foreign key in the Client table
                 */
                string loginCmd = "Insert into dbo.Login (username, password, role) values (@usern, @pass, @role)";
                account.myCommand.CommandText = loginCmd;
                account.myCommand.Parameters.AddWithValue("usern", username.Text);
                account.myCommand.Parameters.AddWithValue("pass", password.Text);
                account.myCommand.Parameters.AddWithValue("role", "Client");


                /* 
                 * To account for SQL injection, I'm attempting to use parameter values instead to account for apostrophes
                 */
                errorFlag = checkAccountInput(errorFlag, account);  

                account.myCommand.ExecuteNonQuery();
                MessageBox.Show("Made it past account insert");

                string cmd = @"Insert into dbo.Client (username, CustomerID, [First Name], [Last Name], [Address], Phone,username) Select username, @Client, @First, @Last, @Address, @Phone, FROM Login WHERE Login.username=@username";  
                //string cmd = "Insert into dbo.Client (username, CustomerID, [First Name], [Last Name], [Address], Phone) values @Client, @First, @Last, @Address, @Phone)";
                datab.myCommand.CommandText = cmd;
                datab.myCommand.Parameters.AddWithValue("Client", ClientID);
                datab.myCommand.Parameters.AddWithValue("First", FirstName.Text);
                datab.myCommand.Parameters.AddWithValue("Last", LastName.Text);
                datab.myCommand.Parameters.AddWithValue("Address", Address.Text);
                datab.myCommand.Parameters.AddWithValue("Phone", Phone);
                datab.myCommand.Parameters.AddWithValue("username", username.Text);
                //MessageBox.Show(datab.myCommand.CommandText);
                datab.myCommand.ExecuteNonQuery();
                    
 

                //errorFlag = checkInput(errorFlag);
                
     
                //datab.myCommand.ExecuteNonQuery();
                //MessageBox.Show(account.myConnection.ToString(), "test") ;
                //datab.myCommand.ExecuteNonQuery();
                //MessageBox.Show("inserted into Client", "successful");
                //account.myCommand.ExecuteNonQuery();
                //MessageBox.Show("inserted into Login", "successful!");
                MessageBox.Show("You have reigistered!", "FINALIZE");
               

            }
            
            catch
            {
                if (errorFlag == 1)
                    MessageBox.Show("ERROR: Something seems to have failed. Please check if your information is correct, or if all information needed is inputted.", "ERROR");
                if (errorFlag == 2)
                    MessageBox.Show("ERROR: conformation password field and password field do not match", "PASSWORD MATCH ERROR");
                else if (errorFlag != 0)
                {
                    MessageBox.Show("SQL ERROR", "DANGIT");
                }
                else
                    MessageBox.Show("ERROR: Username already exists");
            }
            

        }

        private void Phone1_TextChanged(object sender, EventArgs e)
        {
            if (Phone1.TextLength == 3)
            {
                Phone2.Focus();
            }
        }

        private void Phone2_TextChanged(object sender, EventArgs e)
        {
            if (Phone2.TextLength == 3)
            {
                Phone3.Focus();
            }
        }

        private void RegisterClient_Load(object sender, EventArgs e)
        {

        }


        public int checkInput(int errorFlag)
        {
            /*
             * checks for input for Client insertion, whether required fields are missing, otherwise set them as null in order to force it to go to catch
             */
            if (FirstName.Text == "First Name")
            {
                MessageBox.Show("Went into First name clause");
                datab.myCommand.Parameters.AddWithValue("First", DBNull.Value);
                return errorFlag = 1;
            }
            if (LastName.Text == "Last Name")
            {
                datab.myCommand.Parameters.AddWithValue("Last", DBNull.Value);
                return errorFlag = 1;
            }
            if (Address.Text == "Address")
            {
                datab.myCommand.Parameters.AddWithValue("Address", DBNull.Value);
                return errorFlag = 1;
            }
            return errorFlag = 0;
        }
        public int checkAccountInput(int errorFlag, database temp)
        {
            /*
             * checks if account information (username, password) is entered, otherwise makes them null in order to force it to go to catch
             */
             if (username.Text == "username")
            {
                temp.myCommand.Parameters.AddWithValue("usern", DBNull.Value);
                return errorFlag = 1;
            }
             if (password.Text == "111111" || password.Text == "")
            {
                temp.myCommand.Parameters.AddWithValue("pass", DBNull.Value);
                return errorFlag = 1;
            }
             if (password.Text != confirm.Text)
            {
                temp.myCommand.Parameters.AddWithValue("pass", DBNull.Value);
                return errorFlag = 2;
            }
            return errorFlag = 0;
        }

        private void FirstName_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "First Name")
            {
                FirstName.Text = "";
                FirstName.ForeColor = Color.Black;
            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "First Name";
                FirstName.ForeColor = Color.Gray;
            }
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (LastName.Text == "Last Name")
            {
                LastName.Text = "";
                LastName.ForeColor = Color.Black;
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (LastName.Text == "")
            {
                LastName.Text = "Last Name";
                LastName.ForeColor = Color.Gray;
            }
        }

        private void Address_Enter(object sender, EventArgs e)
        {
            if (Address.Text == "Address")
            {
                Address.Text = "";
                Address.ForeColor = Color.Black;
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (Address.Text == "")
            {
                Address.Text = "Address";
                Address.ForeColor = Color.Gray;
            }
        }

        private void Phone1_Enter(object sender, EventArgs e)
        {
            if (Phone1.Text == "780")
            {
                Phone1.Text = "";
                Phone1.ForeColor = Color.Black;
            }
        }

        private void Phone1_Leave(object sender, EventArgs e)
        {
            if (Phone1.Text == "")
            {
                Phone1.Text = "780";
                Phone1.ForeColor = Color.Gray;
            }
        }

        private void Phone2_Enter(object sender, EventArgs e)
        {
            if (Phone2.Text == "???")
            {
                Phone2.Text = "";
                Phone2.ForeColor = Color.Black;
            }
        }

        private void Phone2_Leave(object sender, EventArgs e)
        {
            if (Phone2.Text == "")
            {
                Phone2.Text = "???";
                Phone2.ForeColor = Color.Gray;
            }
        }

        private void Phone3_Enter(object sender, EventArgs e)
        {
            if (Phone3.Text == "????")
            {
                Phone3.Text = "";
                Phone3.ForeColor = Color.Black;
            }
        }

        private void Phone3_Leave(object sender, EventArgs e)
        {
            if (Phone3.Text == "")
            {
                Phone3.Text = "????";
                Phone3.ForeColor = Color.Gray;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "username";
                username.ForeColor = Color.Gray;
            }
        }
    }
}
