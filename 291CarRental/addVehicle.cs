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
    public partial class addVehicle : Form
    {
        /* Form created by Alex Creencia, April 3
         * 
         * 
         * VARIABLE                         DESCRIPTION
         * data                             a database class object that holds the connection to the database
         * maker                            a string that holds the name of the car maker
         * carFrame                         a string that holds the name of the car Frame (e.g. sedan, suv)
         * models                           array holding all models associated to the specific car maker and car frame
         * 
         */
        private database data;
        private string maker;
        private string carFrame;
        private string[] models;
        public addVehicle(database temp)
        {
            InitializeComponent();
            data = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitCurrent_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void makerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // only add car frames for vehicles we want to take in (this can be expanded, for the scope of this project only doing a few)
            typeSelect.Items.Clear();
            string[] ford = new string[] { "suv", "coupe", "sedans", "hatch", "truck" };
            string[] honda = new string[] {"sedan", "suv"};
            string[] toyota = new string[] { "suv", "sedan"};
            maker = (string) makerSelect.SelectedItem;
            switch (maker)
            {
                case ("Porsche"):
                    typeSelect.Items.Add("convertible");
                    break;
                case ("Ford"):
                    typeSelect.Items.AddRange(ford);
                    break;
                case ("Honda"):
                    typeSelect.Items.AddRange(honda);
                    break;
                case ("Toyota"):
                    typeSelect.Items.AddRange(toyota);
                    break;

            }
           
            
            //MessageBox.Show(maker);
        }

        private void typeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelBox.Items.Clear();
            carFrame = (string)typeSelect.SelectedItem;
            //MessageBox.Show(carFrame);
            CarModels modelArray = new CarModels(maker, carFrame);
            models = modelArray.returnValues();
            modelBox.Items.AddRange(models);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            /*
             * Insert the vehicle into the database
             */
            try
            {
                // first need to grab the type of vehicle from the database (foreign key)
                string cmd = "SELECT [Type of Vehicle] FROM CarType Where CarType.[Type of Vehicle]=@type";
                data.myCommand.CommandText = cmd;
                data.myCommand.Parameters.AddWithValue("type", typeSelect.SelectedItem);
                string carType = (string)data.myCommand.ExecuteScalar();
                data.myCommand.Parameters.Clear();


                // now that we have the foreign key, we can now insert
                Guid vehicleId = Guid.NewGuid();
                string insertCmd = "INSERT into Car Values (@id, @color, @model, @make, @status, @type, @user)";
                data.myCommand.CommandText = insertCmd;
                data.myCommand.Parameters.AddWithValue("id", vehicleId);
                data.myCommand.Parameters.AddWithValue("color", colorSelect.SelectedItem);
                data.myCommand.Parameters.AddWithValue("model", modelBox.SelectedItem);
                data.myCommand.Parameters.AddWithValue("make", makerSelect.SelectedItem);
                data.myCommand.Parameters.AddWithValue("status", 0);
                data.myCommand.Parameters.AddWithValue("type", carType);
                data.myCommand.Parameters.AddWithValue("user", DBNull.Value);
                data.myCommand.ExecuteNonQuery();
                data.myCommand.Parameters.Clear();
                MessageBox.Show("Inserted successfully!");
                vehicleTab.Focus();
                this.carTableAdapter.Fill(this._291GroupProjectDataSet1.Car);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291GroupProjectDataSet1.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this._291GroupProjectDataSet1.Car);
            // TODO: This line of code loads data into the '_291GroupProjectDataSet1.Car' table. You can move, or remove it, as needed.



        }
    }
}
