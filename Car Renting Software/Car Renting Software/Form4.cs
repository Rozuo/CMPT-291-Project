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
        private string cmd;
        private Dictionary<String, String> parameters = new Dictionary<String, String>();

        private SqlDataReader dataRead;
        private SqlCommand dataCommand;
        private SqlConnection dataConnection = new SqlConnection(@"Data Source=DESKTOP-9JM8HEJ;Initial Catalog = 291GroupProject;Integrated Security = True");

        public Form4()
        {
            InitializeComponent();
            dataConnection.Open();
            dataCommand = new SqlCommand();
            dataCommand.Connection = dataConnection;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void carIDBox_TextChanged(object sender, EventArgs e)
        {
            carID = carIDBox.Text;
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
                foreach(KeyValuePair<string, string> param in parameters)
                {
                    cmd = cmd + param.Key + " = " + param.Value + " and ";
                    switch (param.Value)
                    {
                        case ("@color"):
                            dataCommand.Parameters.AddWithValue("color", color);
                            break;
                        case ("@model"):
                            dataCommand.Parameters.AddWithValue("model", model);
                            break;
                        case ("@make"):
                            dataCommand.Parameters.AddWithValue("make", make);
                            break;
                        case ("@type"):
                            dataCommand.Parameters.AddWithValue("type", type);
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
            dataCommand.CommandText = cmd;
            try
            {
                dataRead = dataCommand.ExecuteReader();
                CarData.DataSource = null;
                CarData.Rows.Clear();
                while (dataRead.Read())
                {
                    CarData.Rows.Add(dataRead["VehicleID"].ToString(), dataRead["Color"].ToString(), dataRead["Model"].ToString(),
                        dataRead["Make"].ToString(),
                        dataRead["Status"].ToString(),
                        dataRead["Type of Vehicle"].ToString(),
                        dataRead["UserID"].ToString());
                }
                dataRead.Close();
                dataCommand.Parameters.Clear();
            }
            catch(Exception e3)
            {
                MessageBox.Show(e3.ToString() + "\n\n\nUR BAD", "Error");
                //dataRead.Close();
                // Close();
            }
        }

        private void CarData_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TypeText_Click(object sender, EventArgs e)
        {

        }
    }
}
