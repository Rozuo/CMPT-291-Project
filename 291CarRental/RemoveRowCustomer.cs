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
    public partial class RemoveRowCustomer : Form
    {
        private _291CarRental.database data = new _291CarRental.database();
        private ReservationCustomer reference;
        public RemoveRowCustomer(ReservationCustomer reservation)
        {
            InitializeComponent();
            reference = reservation;
        }

        private void RemoveRowCustomer_Load(object sender, EventArgs e)
        {
            data.myCommand.CommandText = "SELECT UserID from Users where Users.username = @uname";
            data.myCommand.Parameters.AddWithValue("uname", reference.data.usr);
            Guid userID = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();

            data.myCommand.CommandText = "SELECT * FROM Reservation where Reservation.UserID =@user";
            data.myCommand.Parameters.AddWithValue("user", userID);
            data.query(data.myCommand.CommandText);
            dataGridView1.DataSource = null;

            while (data.myReader.Read())
            {
                dataGridView1.Rows.Add(data.myReader["ReservationID"].ToString(),
                     data.myReader["Start date"].ToString(),
                     data.myReader["End date"].ToString(),
                     data.myReader["Total Price"].ToString(),
                     data.myReader["BranchID"].ToString(),
                     data.myReader["VehicleID"].ToString(),
                     data.myReader["UserID"].ToString());

            }

            data.myCommand.Parameters.Clear();
            data.myReader.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int theSelectedRow;
            int amountOfRows;
            if (e.RowIndex != -1)
            {
                theSelectedRow = e.RowIndex;
                amountOfRows = dataGridView1.SelectedRows.Count;

                String[] dataString = new String[dataGridView1.Columns.Count];
                String[] header = new String[dataGridView1.Columns.Count];
                foreach (DataGridViewRow theRow in dataGridView1.SelectedRows)
                {
                    for (int i = 0; i < dataString.Length; i++)
                    {
                        //MessageBox.Show(theRow.Cells[i].Value.ToString());
                        dataString[i] = theRow.Cells[i].Value.ToString();
                        header[i] = dataGridView1.Columns[i].HeaderText;
                    }
                }
                string rowData = "";
                for (int i = 0; i < dataString.Length; i++)
                {
                    rowData += dataString[i];
                }
                DateTime selectedDate = Convert.ToDateTime(dataString[Array.IndexOf(header, "Start date")]);
                DateTime currentTime = DateTime.Now;
                /*messagebox to ask if the customer is sure they wants to do that*/
                string warningMessage = "Are you sure to delete this reservation?";
                string titleMessage = "Warning";
                MessageBoxButtons warningBox = MessageBoxButtons.YesNo;
                DialogResult answer = MessageBox.Show(warningMessage, titleMessage, warningBox);
                if (answer == DialogResult.Yes)
                {
                    /*delete reservation base on whether the start date has passed the current day*/
                    if ((selectedDate - currentTime).TotalDays <= 0)
                    {
                        MessageBox.Show("You cannot remove this reservation");
                    }
                    else
                    {
                        data.myCommand.CommandText =
                            "DELETE FROM Reservation where Reservation.ReservationID = @res";
                        Guid reservedID = Guid.Parse(dataString[Array.IndexOf(header, "ReservationID")]);
                        data.myCommand.Parameters.AddWithValue("res", reservedID);
                        data.myCommand.ExecuteNonQuery();
                        data.myCommand.Parameters.Clear();
                        updateRevTable();
                        //this.reservationTableAdapter.Fill(this._291GroupProjectDataSet.Reservation);
                        reference.updateTable();
                    }
                }

                //for (int i = 0; i < dataString.Length; i++)
                //{
                //CarInfoBox.Text = CarInfoBox.Text + dataString[i] + "\n";
                //}
            }
        }

        private void updateRevTable()
        {
            data.myCommand.CommandText = "SELECT UserID from Users where Users.username = @uname";
            data.myCommand.Parameters.AddWithValue("uname", reference.data.usr);
            Guid userID = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();

            data.myCommand.CommandText = "SELECT * FROM Reservation where Reservation.UserID =@user";
            data.myCommand.Parameters.AddWithValue("user", userID);
            data.query(data.myCommand.CommandText);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            while (data.myReader.Read())
            {
                dataGridView1.Rows.Add(data.myReader["ReservationID"].ToString(),
                     data.myReader["Start date"].ToString(),
                     data.myReader["End date"].ToString(),
                     data.myReader["Total Price"].ToString(),
                     data.myReader["BranchID"].ToString(),
                     data.myReader["VehicleID"].ToString(),
                     data.myReader["UserID"].ToString());

            }

            data.myCommand.Parameters.Clear();
            data.myReader.Close();
        }
        private void cancelB_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
