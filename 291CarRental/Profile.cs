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
        private database datab;
        public Profile(database temp)
        {
            InitializeComponent();
            datab = temp;
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            /*
             * Loads all the necessary information upon the user loading the form. 
             */
            string cmd = "SELECT * FROM Users WHERE Users.username=@user";
            datab.myCommand.CommandText = cmd;
            datab.myCommand.Parameters.AddWithValue("user", datab.usr);
            try
            {
                //datab.myCommand.ExecuteReader();
                SqlDataAdapter sda = new SqlDataAdapter(datab.myCommand);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                firstName.Text = dt.Rows[0]["First Name"].ToString();
                lastName.Text = dt.Rows[0]["Last Name"].ToString();
                Address.Text = dt.Rows[0]["Address"].ToString();
                if (dt.Rows[0]["CreditCardNum"].Equals(DBNull.Value))
                    CreditCard.Text = "Information Not Entered";
                else
                {
                    string temp = dt.Rows[0]["CreditCardNum"].ToString();
                    CreditCard.Text = temp.Substring(0,3) + " ****  **** ****";
                }
                string phoneOriginal = dt.Rows[0]["Phone"].ToString();
                Phone.Text = phoneOriginal.Substring(0, 3) + " - " + phoneOriginal.Substring(3, 3) + " - " + phoneOriginal.Substring(6);
                bool isSet = (bool) dt.Rows[0]["Gold"];
                if (!isSet)
                    Gold.Text = "No";
                else
                    Gold.Text = "Yes!";
                firstTBox.Text = firstName.Text;
                lastTBox.Text = lastTBox.Text;
                addressTBox.Text = Address.Text;
                CreditTBox.Text = CreditCard.Text;
                Phone1.Text = phoneOriginal.Substring(0, 3);
                Phone2.Text = phoneOriginal.Substring(3, 3);
                Phone3.Text = phoneOriginal.Substring(6);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
                Application.Exit();
            }
        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
