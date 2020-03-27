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
            checkInput();
            Guid ClientID = Guid.NewGuid();
            string Phone = Phone1.Text + Phone2.Text + Phone3.Text;

            try
            {
                /* 
                 * To account for SQL injection, I'm attempting to use parameter values instead to account for apostrophes
                 */
                
                 string cmd = "Insert into dbo.Client (CustomerID, [Total Year Rent], [First Name], [Last Name], Address, CreditCardNum, Phone) values (@Client, @Rent, @First, @Last, @Address, @Credit, @Phone)";
                 datab.myCommand.CommandText = cmd;
                 //datab.myCommand.Parameters.AddWithValue("Client", NEWID());
                 datab.myCommand.Parameters.AddWithValue("Client", ClientID);
                 datab.myCommand.Parameters.AddWithValue("Rent", DBNull.Value);
                 datab.myCommand.Parameters.AddWithValue("First", FirstName.Text);
                 datab.myCommand.Parameters.AddWithValue("Last", LastName.Text);
                 datab.myCommand.Parameters.AddWithValue("Address", Address.Text);
                 datab.myCommand.Parameters.AddWithValue("Credit", DBNull.Value);
                 datab.myCommand.Parameters.AddWithValue("Phone", Phone);

                 //MessageBox.Show(datab.myCommand.CommandText);

                 datab.myCommand.ExecuteNonQuery();
                 MessageBox.Show("You have reigistered!", "FINALIZE");
               

            }
            
            catch
            {
                HandleError();
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
        public void reset()
        {
            RegisterClient registerClient = new RegisterClient(datab);
            this.Dispose(false);
            this.Close();
            registerClient.ShowDialog();
        }
        public void HandleError()
        {
            MessageBox.Show("ERROR: Something seems to have failed. Please check if your information is correct, or if all information needed is inputted.", "ERROR");
            reset();

        }
        public void checkInput()
        {
            if (FirstName.Text == "First Name")
                HandleError();
            if (LastName.Text == "Last Name")
                HandleError();
            if (Address.Text == "Address")
                HandleError();
        }
    }
}
