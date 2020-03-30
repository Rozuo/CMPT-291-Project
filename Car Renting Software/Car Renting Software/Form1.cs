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
    public partial class Form1 : Form
    {

        private string name;
        private string make;
        private string model;
        private string type;
        private string color;
        private string carID;
        private string cmd;

        private SqlDataReader dataRead;
        private SqlCommand dataCommand;
        private SqlConnection dataConnection = new SqlConnection(@"Data Source=X-MK1;Initial Catalog = 291GroupProject;Integrated Security = True");

        public Form1()
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
            // TODO: This line of code loads data into the '_291GroupProjectDataSet2.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter1.Fill(this._291GroupProjectDataSet2.Car);
            // TODO: This line of code loads data into the '_291GroupProjectDataSet1.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this._291GroupProjectDataSet1.Car);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void colorBox_TextChanged(object sender, EventArgs e)
        {
            color = colorBox.Text;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modelBox_TextChanged(object sender, EventArgs e)
        {
            model = modelBox.Text;
        }

        private void typeBox_TextChanged(object sender, EventArgs e)
        {
            type = typeBox.Text;
        }

        private void availableCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void makeBox_TextChanged(object sender, EventArgs e)
        {
            make = makeBox.Text;
        }
        
        private void filterButton_Click(object sender, EventArgs e)
        {
            cmd = "Select * from Car where Car.Color = @color and Car.Model = @model and Car.Make = @make and Car.[Type of Vehicle] = @type";
            dataCommand.CommandText = cmd;
            dataCommand.Parameters.AddWithValue("color", color);
            dataCommand.Parameters.AddWithValue("model", model); 
            dataCommand.Parameters.AddWithValue("make", make); 
            dataCommand.Parameters.AddWithValue("type", type);

            try
            {
                dataRead = dataCommand.ExecuteReader();
                //dataGridView1.Rows.Clear();
                /*while (dataRead.Read())
                {
                    dataGridView1.Rows.Add(dataRead["VehicleID"].ToString(), dataRead["Type of Vehicle"].ToString(), dataRead["Color"].ToString(),
                        dataRead["Model"].ToString(),
                        dataRead["Make"].ToString(),
                        dataRead["Status"].ToString(),
                        dataRead["CustomerID"].ToString());
                }*/
            }
            catch
            {
                MessageBox.Show("UR BAD");
                //dataRead.Close();
                // Close();
            }
        }
    }
}
