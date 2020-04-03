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
    public partial class ProcessReturns : Form
    {

        private database data;
        private string[] dataString;
        private int amountOfRows;
        private int theSelectedRow;
        private string vehicleID;
        private string cmd;
        private bool lateCheck = false;
        private int lateFee = 200;
        public ProcessReturns(database data)
        {
            InitializeComponent();
            this.data = data;
            dataString = new string[carData.Columns.Count];
        }

        private void ProcessReturns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291GroupProjectDataSetCar.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this._291GroupProjectDataSetCar.Car);

        }

        private void carData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex != -1)
                {
                    infoBox.Clear();
                    theSelectedRow = e.RowIndex;
                    amountOfRows = carData.SelectedRows.Count;
                    string[] columnHeaders = new string[carData.Columns.Count];


                    foreach (DataGridViewRow theRow in carData.SelectedRows)
                    {
                        for (int i = 0; i < dataString.Length; i++)
                        {
                            dataString[i] = theRow.Cells[i].Value.ToString();
                            columnHeaders[i] = carData.Columns[i].HeaderText;
                        }
                    }

                    for (int i = 0; i < dataString.Length; i++)
                    {
                        if (dataString[i].Equals(""))
                        {
                            //infoBox.Text += "Car Status: " + "AVAILABLE" + "\n";
                            continue;
                        }
                        else if (columnHeaders[i].Equals("Status"))
                        {
                            switch (dataString[i])
                            {
                                case ("0"):
                                    infoBox.Text += columnHeaders[i] + ": AVAILABLE\n";
                                    break;
                                case ("1"):
                                    infoBox.Text += columnHeaders[i] + ": IN USE\n";
                                    break;
                                case ("2"):
                                    infoBox.Text += columnHeaders[i] + ": UNDER REPAIRS\n";
                                    break;
                            }
                        }
                        else
                        {
                            infoBox.Text += columnHeaders[i] + ": " + dataString[i] + "\n";
                        }
                    }
                }
           
        }

        private void vehicleIDBox_TextChanged(object sender, EventArgs e)
        {
            vehicleID = vehicleIDBox.Text;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            cmd = "Select* from Car where VehicleID = @carID";
            data.myCommand.Parameters.AddWithValue("carID", vehicleID);

            try
            {
                data.query(cmd);
                //dataRead = dataCommand.ExecuteReader();
                carData.DataSource = null;
                carData.Rows.Clear();
                while (data.myReader.Read())
                {
                    carData.Rows.Add(data.myReader["VehicleID"].ToString(), data.myReader["Color"].ToString(), data.myReader["Model"].ToString(),
                        data.myReader["Make"].ToString(),
                        data.myReader["Status"].ToString(),
                        data.myReader["Type of Vehicle"].ToString(),
                        data.myReader["UserID"].ToString());
                }

                data.myReader.Close();
                //dataCommand.Parameters.Clear();
                data.clearParameters();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                //dataRead.Close();
                // Close();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (dataString[dataString.Length - 1].Equals("") || dataString[4].Equals("0") || dataString[4].Equals("2"))
            {
                MessageBox.Show("This car does not need to be returned.");
                return;
            }

            if (lateCheck)
            {
                cmd = "SELECT Price FROM ExtraFee WHERE ExtraFee.[Types of fee] = @fee";
                data.myCommand.CommandText = cmd;
                /*
                data.myCommand.Parameters.AddWithValue("fee", lateFee));
                data.q*/
            }

            
            try
            {
                cmd = "update Car set Status = @status, UserID = @userID where Car.VehicleID = @carID";
                data.myCommand.Parameters.AddWithValue("status", "0");
                data.myCommand.Parameters.AddWithValue("carID", dataString[0]);
                data.myCommand.Parameters.AddWithValue("userID", DBNull.Value);
                data.update(cmd);
                data.clearParameters();
                this.carTableAdapter.Fill(this._291GroupProjectDataSetCar.Car);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString());
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void late_CheckedChanged(object sender, EventArgs e)
        {
            if (lateCheck)
            {
                lateCheck = false;
            }
            else
            {
                lateCheck = true;
            }
        }
    }
}
