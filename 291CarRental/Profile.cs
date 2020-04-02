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
    public partial class Profile : Form
    {
        /* Profile Form
         * Created by Alex Creencia March 31, 2020
         * This code is heavily based on code by Ross B. from file CarRental.cs within Car Rental Software project
         * 
         * VARIABLE                     DESCRIPTION
         * datab                        a database object passed on from other forms calling this form, contains username of current user + connection
         * phoneFlag                    a boolean flag which tells the code whether the user changed the Phone text boxes or not, in order to determine whether to update phone information
         * parameters                   a dictionary that contains all the parameterized parameters for the UPDATE query
         * phoneNum                     a string that holds the full Phone Number of the user
         * reload                       a boolean that determines whether the form was loaded or reloaded, in order to not fill the sda when it is already full
         */

        private database datab;
        private bool phoneFlag;
        private Dictionary<String, String> parameters = new Dictionary<String, String>();
        private string PhoneNum;
        private bool reload = false;
        public Profile(database temp)
        {
            InitializeComponent();
            datab = temp;
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReloadForm()
        {
            /*
             * Function which loads/reloads user information (this is mainly used in conjunction with the information updating tab
             */
            string cmd = "SELECT * FROM Users WHERE Users.username=@user";
            datab.myCommand.CommandText = cmd;
            datab.myCommand.Parameters.AddWithValue("user", datab.usr);
            try
            {
                //datab.myCommand.ExecuteReader();
  
                SqlDataAdapter sda = new SqlDataAdapter(datab.myCommand);
                DataTable dt = new System.Data.DataTable();
                if (reload)
                {
                    sda.Update(dt);
                    sda.Dispose();
                    datab.myCommand.Parameters.Clear();
                    return;
                }
                sda.Fill(dt);
                firstName.Text = dt.Rows[0]["First Name"].ToString();
                lastName.Text = dt.Rows[0]["Last Name"].ToString();
                Address.Text = dt.Rows[0]["Address"].ToString();
                if (dt.Rows[0]["CreditCardNum"].Equals(DBNull.Value))
                    CreditCard.Text = "Information Not Entered";
                else
                {
                    string temp = dt.Rows[0]["CreditCardNum"].ToString();
                    CreditCard.Text = temp.Substring(0, 3) + " ****  **** ****";
                }
                string phoneOriginal = dt.Rows[0]["Phone"].ToString();
                PhoneNum = phoneOriginal;
                Phone.Text = phoneOriginal.Substring(0, 3) + " - " + phoneOriginal.Substring(3, 3) + " - " + phoneOriginal.Substring(6);
                bool isSet = (bool)dt.Rows[0]["Gold"];
                if (!isSet)
                    Gold.Text = "No";
                else
                    Gold.Text = "Yes!";
                
                // displaying onto the settings tab
                firstTBox.Text = firstName.Text;
                lastTBox.Text = lastName.Text;
                addressTBox.Text = Address.Text;
                CreditTBox.Text = CreditCard.Text;
                Phone1.Text = phoneOriginal.Substring(0, 3);
                Phone2.Text = phoneOriginal.Substring(3, 3);
                Phone3.Text = phoneOriginal.Substring(6);
                datab.myCommand.Parameters.Clear();
                sda.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
                Application.Exit();
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            /*
             * Loads all the necessary information upon the user loading the form. 
             */
            ReloadForm();
        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstTBox_TextChanged(object sender, EventArgs e)
        {
            if (!parameters.ContainsKey("Users.[First Name]"))
                parameters.Add("Users.[First Name]", "@First");
            if (firstTBox.Text.Equals(""))
                parameters.Remove("Users.[First Name]");
            if (firstTBox.Text.Equals(firstName.Text))
                parameters.Remove("Users.[First Name]");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            datab.myConnection.Close();
            this.Close();

        }

        private void lastTBox_TextChanged(object sender, EventArgs e)
        {
            if (!parameters.ContainsKey("Users.[Last Name]"))
                parameters.Add("Users.[Last Name]", "@Last");
            if (firstTBox.Text.Equals(""))
                parameters.Remove("Users.[Last Name]");
            if (lastTBox.Text.Equals(lastName.Text))
                parameters.Remove("Users.[Last Name]");
        }

        private void addressTBox_TextChanged(object sender, EventArgs e)
        {
            if (!parameters.ContainsKey("Users.[Address]"))
                parameters.Add("Users.[Address]", "@Address");
            if (firstTBox.Text.Equals(""))
                parameters.Remove("Users.[Address]");
            if (addressTBox.Text.Equals(Address.Text))
                parameters.Remove("Users.[Address]");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // First check if Phone text boxes were changed
            /*
             * Obtains all necessary/changed fields to update the information of the user
             */
            if (phoneFlag)
            {
                string Phone = Phone1.Text + Phone2.Text + Phone3.Text;
                if (!parameters.ContainsKey("Users.[Phone]"))
                    parameters.Add("Users.[Phone]", "@Phone");

            }
            else if (!phoneFlag && parameters.ContainsKey("Users.[Phone]"))
                parameters.Remove("Users.[Phone]");
            string cmd = "UPDATE Users SET ";
            if (parameters.Count > 0)
            {
                foreach (KeyValuePair<string, string> param in parameters)
                {
                    cmd = cmd + param.Key + " = " + param.Value + ", ";
                    switch(param.Value)
                    {
                        case ("@First"):
                            datab.myCommand.Parameters.AddWithValue("First", firstTBox.Text);
                            break;
                        case ("@Last"):
                            datab.myCommand.Parameters.AddWithValue("Last", lastTBox.Text);
                            break;
                        case ("@Address"):
                            datab.myCommand.Parameters.AddWithValue("Address", addressTBox.Text);
                            break;
                        case ("@Phone"):
                            datab.myCommand.Parameters.AddWithValue("Phone", Phone);
                            break;
                        case ("@Credit"):
                            datab.myCommand.Parameters.AddWithValue("Credit", CreditTBox.Text);
                            break;

                    }
                }
                int lastComma = cmd.LastIndexOf(", ");
                cmd = cmd.Remove(lastComma);
                cmd = cmd + " WHERE Users.username=@User";
                try
                {
                    datab.myCommand.Parameters.AddWithValue("User", datab.usr);
                    if (datab.myConnection.State == ConnectionState.Closed)
                        datab.myConnection.Open();
                    datab.query(cmd);
                    MessageBox.Show("Fields were Changed, Please Exit and Enter to view changes", "ALERT");
                    datab.myCommand.Parameters.Clear();
                    // call on Load
                    reload = true;
                    ReloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
                
            }
            else
            {
                // if no fields were changed, do nothing
                MessageBox.Show("NOTE: No fields were changed", "ALERT");
            }
        }

        private void Phone1_TextChanged(object sender, EventArgs e)
        {
            //perhaps set a flag indicating that the phone # has changed. 
            phoneFlag = true;
            if (Phone1.Text == "")
                phoneFlag = false;
            if (Phone1.Text == PhoneNum.Substring(0, 3))
                phoneFlag = false;
        }

        private void Phone2_TextChanged(object sender, EventArgs e)
        {
            phoneFlag = true;
            if (Phone2.Text == "")
                phoneFlag = false;
            if (Phone2.Text == PhoneNum.Substring(3, 3))
                phoneFlag = false;
        }

        private void Phone3_TextChanged(object sender, EventArgs e)
        {
            phoneFlag = true;
            if (Phone3.Text == "")
                phoneFlag = false;
            if (Phone3.Text == PhoneNum.Substring(6))
                phoneFlag = false;
        }

        private void CreditTBox_TextChanged(object sender, EventArgs e)
        {
            if (!parameters.ContainsKey("Users.[CreditCardNum]"))
                parameters.Add("Users.[CreditCardNum]", "@Credit");
            if (firstTBox.Text.Equals(""))
                parameters.Remove("Users.[CreditCardNum]");
            if (CreditTBox.Text == "Information Not Entered")
                parameters.Remove("Users.[CreditCardNum]");
            if (CreditTBox.Text.Equals(CreditCard.Text))
                parameters.Remove("Users.[CreditCardNum]");
        }
    }
}
