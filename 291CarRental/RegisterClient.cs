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
            Guid UserID = Guid.NewGuid();
            string Phone = Phone1.Text + Phone2.Text + Phone3.Text;
            database temp = new database(); // remember that objects are pass by reference --> I cannot set temp to datab, otherwise it will overwrite the contents of datab.
            try
            {
                /* 
                 * To account for SQL injection, I'm attempting to use parameter values instead to account for apostrophes
                 */



                string cmd = "Insert into dbo.Users (UserID, username, password, [First Name], [Last Name], Address, Phone, Gold, role) values (@ID, @user, @pass, @First, @Last, @Add, @Phone, @Gold, @role)";  

                datab.myCommand.CommandText = cmd;
                datab.myCommand.Parameters.AddWithValue("ID", UserID);
                datab.myCommand.Parameters.AddWithValue("user", username.Text.ToUpper());
                datab.myCommand.Parameters.AddWithValue("pass", password.Text);
                datab.myCommand.Parameters.AddWithValue("First", FirstName.Text);
                datab.myCommand.Parameters.AddWithValue("Last", LastName.Text);
                datab.myCommand.Parameters.AddWithValue("Add", Address.Text);
                datab.myCommand.Parameters.AddWithValue("Phone", Phone);
                datab.myCommand.Parameters.AddWithValue("Gold", 0);                         // could also use 'true' or 'false'
                datab.myCommand.Parameters.AddWithValue("role", "Client");
                errorFlag = checkInput(errorFlag, Phone);
                errorFlag = usernameExists(errorFlag, temp);  
                MessageBox.Show(datab.myCommand.CommandText.ToString());
                datab.myCommand.ExecuteNonQuery();
                

                MessageBox.Show("You have reigistered!", "FINALIZE");
                datab.myCommand.Parameters.Clear();
                this.Close();
               

            }
            
            catch
            {
                if (errorFlag == 1)
                    MessageBox.Show("ERROR: Something seems to have failed. Please check if your information is correct, or if all information needed is inputted.", "ERROR");
                if (errorFlag == 2)
                    MessageBox.Show("ERROR: conformation password field and password field do not match", "PASSWORD MATCH ERROR");
                if (errorFlag == 3)
                    MessageBox.Show("ERROR: Username already exists. Please try again with a different username");
                else
                    MessageBox.Show("An unexpected Error occured:: SQL");   
                datab.myCommand.Parameters.Clear();

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

        public int usernameExists(int flag, database copy)
        {
            /*
             * Checks whether the username exists within database, and sets flag condition to display the correct error message.
             */
            database temp = copy;
            string userSearch = "SELECT count (*) FROM Users WHERE Users.username=@Username";
            temp.myCommand.CommandText = userSearch;
            temp.myCommand.Parameters.AddWithValue("@Username", username.Text.ToUpper());


            Boolean test = (int)temp.myCommand.ExecuteScalar() > 0;
            if (test == true)
            {
                datab.myCommand.Parameters.AddWithValue("user", DBNull.Value);
                return flag = 3;
            }
            return flag;
        }

        public int checkInput(int errorFlag, string Phone)
        {
            /*
             * checks for input for Client insertion, whether required fields are missing, otherwise set them as null in order to force it to go to catch
             */
            if (FirstName.Text == "First Name")
            {
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
                datab.myCommand.Parameters.AddWithValue("Add", DBNull.Value);
                return errorFlag = 1;
            }
            if (username.Text == "username")
            {
                datab.myCommand.Parameters.AddWithValue("usern", DBNull.Value);
                return errorFlag = 1;
            }
            if (password.Text == "111111" || password.Text == "")
            {
                datab.myCommand.Parameters.AddWithValue("pass", DBNull.Value);
                return errorFlag = 1;
            }
            if (password.Text != confirm.Text)
            {
                datab.myCommand.Parameters.AddWithValue("pass", DBNull.Value);
                return errorFlag = 2;
            }
            if (Phone == "780???????" || Phone.Length != 10)
                datab.myCommand.Parameters.AddWithValue("Phone", DBNull.Value);     // in case the user doesn't input their phone # correctly, just make it Null
            return errorFlag;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "111111")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "111111";
                password.ForeColor = Color.Gray;
            }
        }

        private void confirm_Enter(object sender, EventArgs e)
        {
            if (confirm.Text == "111111")
            {
                confirm.Text = "";
                confirm.ForeColor = Color.Black;
            }
        }

        private void confirm_Leave(object sender, EventArgs e)
        {
            if (confirm.Text == "")
            {
                confirm.Text = "111111";
                confirm.ForeColor = Color.Gray;
            }
        }
    }
}
