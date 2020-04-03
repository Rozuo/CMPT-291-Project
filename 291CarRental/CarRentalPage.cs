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

namespace Car_Renting_Software
{
    public partial class Form4 : Form
    {
        private string make;
        private string model;
        private string type;
        private string color;
        private string carID;
        private string[] dataString;
        private int    availableCarsOnly = 0;

        private int theSelectedRow;
        private int amountOfRows;

        private string cmd;
        private Dictionary<String, String> parameters = new Dictionary<String, String>();


        private _291CarRental.database datab; //= new _291CarRental.database(@"Data Source=X-MK1;Initial Catalog = 291GroupProject;Integrated Security = True");
        /*
        private SqlDataReader dataRead;
        private SqlCommand dataCommand;
        private SqlConnection dataConnection = new SqlConnection(@"Data Source=X-MK1;Initial Catalog = 291GroupProject;Integrated Security = True");
        */
        public Form4(_291CarRental.database datab)
        {
            InitializeComponent();
            this.datab = datab;
            /*
            dataConnection.Open();
            dataCommand = new SqlCommand();
            dataCommand.Connection = dataConnection;
            */
            dataString = new string[CarData.Columns.Count];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!dataString[dataString.Length-1].Equals("") || !dataString[4].Equals("0"))
            {
                MessageBox.Show("This car is taken or is under repairs. Select another one.");
                return;
            }
            WindowsFormsApp1.Reservation reserve = new WindowsFormsApp1.Reservation(datab, dataString);
            reserve.ShowDialog();
            Close();
        }

        private void carIDBox_TextChanged(object sender, EventArgs e)
        {
            carID = carIDBox.Text;
            // if the parameter already exists do not add it
            if (!parameters.ContainsKey("Car.VehicleID"))
            {
                parameters.Add("Car.VehicleID", "@carID");
            }
            // if the text box is empty get rid of the parameter.
            if (carIDBox.Text.Equals(""))
            {
                parameters.Remove("Car.VehicleID");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291GroupProjectDataSetCar.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this._291GroupProjectDataSetCar.Car);
            // TODO: This line of code loads data into the '_291GroupProjectDataSet2.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter1.Fill(this._291GroupProjectDataSet2.Car);
            // TODO: This line of code loads data into the '_291GroupProjectDataSet1.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this._291GroupProjectDataSet1.Car);

        }

        private void colorBox_TextChanged(object sender, EventArgs e)
        {
            color = colorBox.Text;

            // if the parameter already exists do not add it
            if (!parameters.ContainsKey("Car.color"))
            {
                parameters.Add("Car.color", "@color");
            }
            // if the text box is empty get rid of the parameter.
            if (colorBox.Text.Equals(""))
            {
                parameters.Remove("Car.color");
            }
        }


        private void modelBox_TextChanged(object sender, EventArgs e)
        {
            model = modelBox.Text;
            if (!parameters.ContainsKey("Car.Model"))
            {
                parameters.Add("Car.Model", "@model");
            }
            if (modelBox.Text.Equals(""))
            {
                parameters.Remove("Car.Model");
            }
        }

        private void typeBox_TextChanged(object sender, EventArgs e)
        {
            type = typeBox.Text;
            if (!parameters.ContainsKey("Car.[Type of Vehicle]"))
            {
                parameters.Add("Car.[Type of Vehicle]", "@type");
            }
            if (typeBox.Text.Equals(""))
            {
                parameters.Remove("Car.[Type of Vehicle]");
            }
        }

        private void availableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (availableCheckBox.Checked && !parameters.ContainsKey("Car.Status"))
            {
                parameters.Add("Car.Status", "@status");
            }
            else
            {
                parameters.Remove("Car.Status");
            }
        }

        private void makeBox_TextChanged(object sender, EventArgs e)
        {
            make = makeBox.Text;
            if (!parameters.ContainsKey("Car.Make"))
            {
                parameters.Add("Car.Make", "@make");
            }
            if (makeBox.Text.Equals(""))
            {
                parameters.Remove("Car.Make");
            }
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            //cmd = "Select * from Car where Car.Color = @color and Car.Model = @model and Car.Make = @make and Car.[Type of Vehicle] = @type";
            cmd = "Select * from Car where ";

            // if the the boxes are filled go through them and add all parameters.
            if(parameters.Count > 0)
            {

                foreach (KeyValuePair<string, string> param in parameters)
                {
                    cmd = cmd + param.Key + " = " + param.Value + " and ";
                    switch (param.Value)
                    {
                        case ("@color"):
                            datab.myCommand.Parameters.AddWithValue("color", color);
                            break;
                        case ("@model"):
                            datab.myCommand.Parameters.AddWithValue("model", model);
                            break;
                        case ("@make"):
                            datab.myCommand.Parameters.AddWithValue("make", make);
                            break;
                        case ("@type"):
                            datab.myCommand.Parameters.AddWithValue("type", type);
                            break;
                        case ("@carID"):
                            datab.myCommand.Parameters.AddWithValue("carID", carID);
                            break;
                        case ("@status"):
                            datab.myCommand.Parameters.AddWithValue("status", availableCarsOnly);
                            break;
                    }
                }

                //MessageBox.Show("cmd = " + cmd);                    // Debug purposes

                int lastAnd = cmd.LastIndexOf(" and ");       // get last index of the and
            
                cmd = cmd.Remove(lastAnd);                    // remove last and
            }
            else
            {
                // This will be used if no text box was filled.
                int where = cmd.LastIndexOf(" where ");
                cmd = cmd.Remove(where);
            }

            // run query
            //dataCommand.CommandText = cmd;
            try
            {
                datab.query(cmd);
                //dataRead = dataCommand.ExecuteReader();
                CarData.DataSource = null;
                CarData.Rows.Clear();
                while (datab.myReader.Read())
                {
                    CarData.Rows.Add(datab.myReader["VehicleID"].ToString(), datab.myReader["Color"].ToString(), datab.myReader["Model"].ToString(),
                        datab.myReader["Make"].ToString(),
                        datab.myReader["Status"].ToString(),
                        datab.myReader["Type of Vehicle"].ToString(),
                        datab.myReader["UserID"].ToString());
                }

                datab.myReader.Close();
                //dataCommand.Parameters.Clear();
                datab.clearParameters();
            }
            catch(Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                //dataRead.Close();
                // Close();
            }
        }

        private void TypeText_Click(object sender, EventArgs e)
        {

        }

        private void makeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                modelBox.Focus();
            }
        }

        private void modelBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                typeBox.Focus();
            }
        }

        private void typeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Tab))
            {
                colorBox.Focus();
            }
        }

        private void colorBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Tab))
            {
                carIDBox.Focus();
            }
        }

        private void carIDBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Tab))
            {
                filterButton.Focus();
            }
        }

        private void filterButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Tab))
            {
                makeBox.Focus();
            }
        }

        private void CarData_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CarInfoBox.Clear();
                theSelectedRow = e.RowIndex;
                amountOfRows = CarData.SelectedRows.Count;
                string[] columnHeaders = new string[CarData.Columns.Count];

                /*
                foreach (DataGridViewColumn theCol in CarData.SelectedColumns) 
                {
                    MessageBox.Show(theCol.HeaderText);
                }*/

                foreach (DataGridViewRow theRow in CarData.SelectedRows)
                {
                    for (int i = 0; i < dataString.Length; i++)
                    {
                        dataString[i] = theRow.Cells[i].Value.ToString();
                        columnHeaders[i] = CarData.Columns[i].HeaderText;
                    }
                }

                for (int i = 0; i < dataString.Length; i++)
                {
                    if(dataString[i].Equals(""))
                    {
                        //CarInfoBox.Text += "Car Status: " + "AVAILABLE" + "\n";
                        continue;
                    }
                    else if (columnHeaders[i].Equals("Status"))
                    {
                        switch (dataString[i])
                        {
                            case ("0"):
                                CarInfoBox.Text += columnHeaders[i] + ": AVAILABLE\n";
                                break;
                            case ("1"):
                                CarInfoBox.Text += columnHeaders[i] + ": IN USE\n";
                                break;
                            case ("2"):
                                CarInfoBox.Text += columnHeaders[i] + ": UNDER REPAIRS\n";
                                break;
                        }
                    }
                    else
                    {
                        CarInfoBox.Text += columnHeaders[i] + ": " + dataString[i] + "\n";
                    }
                }
            }
        }
    }
}
