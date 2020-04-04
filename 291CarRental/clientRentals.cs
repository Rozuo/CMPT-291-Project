using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291CarRental
{
    public partial class clientRentals : Form
    {
        private database data;
        private string cmd;
        private int rowIndex;
        private DataGridViewRow row;
        public clientRentals(database data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void clientRentals_Load(object sender, EventArgs e)
        {
            cmd = "Select UserID from users where users.username = @theUsername";
            data.myCommand.CommandText = cmd;
            data.myCommand.Parameters.AddWithValue("theUsername", data.usr);
            Guid user = (Guid) data.myCommand.ExecuteScalar();
            data.clearParameters();

            cmd = "Select * from Reservation where Reservation.UserID = @username";
            data.myCommand.Parameters.AddWithValue("username", user.ToString());
            try
            {
                data.query(cmd);
                //dataRead = dataCommand.ExecuteReader();
                reservationData.DataSource = null;
                reservationData.Rows.Clear();
                while (data.myReader.Read())
                {
                    reservationData.Rows.Add(data.myReader["ReservationID"].ToString(), data.myReader["Start date"].ToString(), data.myReader["End date"].ToString(),
                        data.myReader["Total Price"].ToString(),
                        data.myReader["BranchID"].ToString(),
                        data.myReader["VehicleID"].ToString(),
                        data.myReader["UserID"].ToString());
                }

                data.myReader.Close();
                //dataCommand.Parameters.Clear();
                data.clearParameters();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                data.myReader.Close();
                //dataRead.Close();
                // Close();
            }
            // TODO: This line of code loads data into the '_291GroupProjectDataSetReservation.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this._291GroupProjectDataSetReservation.Reservation);

        }



        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservationData.Rows.Remove(row);
        }

        private void reservationData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = reservationData.Rows[e.RowIndex];
        }
    }
}
