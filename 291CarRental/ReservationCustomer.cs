﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReservationCustomer : Form
    {
        public _291CarRental.database data;
        public string username;
        public string[] dataString;
        public Guid carID;
        public ReservationCustomer(_291CarRental.database data, string[] dataString)
        {
            InitializeComponent();
            this.data = data;
            this.dataString = dataString;
            carID = Guid.Parse(dataString[0]);
        }

        private void ReservationCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291GroupProjectDataSet.Reservation' table. You can move, or remove it, as needed.
            //_291GroupProjectDataSet.Reservation.UserIDColumn.ColumnName
            /*get the useID*/

            data.myCommand.CommandText = "SELECT UserID from Users where Users.username = @uname";
            data.myCommand.Parameters.AddWithValue("uname", data.usr);
            Guid userID = Guid.Parse(data.myCommand.ExecuteScalar().ToString());
            //String userID = data.myCommand.ExecuteScalar().ToString();
            data.myCommand.Parameters.Clear();

            data.myCommand.CommandText = "SELECT * FROM Reservation where Reservation.UserID =@user";
            data.myCommand.Parameters.AddWithValue("user",userID);
            data.query(data.myCommand.CommandText);
            dataGridView1.DataSource = null;
            
            while (data.myReader.Read()){
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

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RemoveRowCustomer removerow = new RemoveRowCustomer(this);
            removerow.ShowDialog();
        }
        /*
        private void addRow_Click(object sender, EventArgs e)
        {
            //the two guid are for testing purpose
            Guid tempCar = new Guid();
            data.myCommand.CommandText = "SELECT VehicleID from Car where Car.[Type of Vehicle] =@Type and Car.Model =@Model";
            data.myCommand.Parameters.AddWithValue("Type", "truck");
            data.myCommand.Parameters.AddWithValue("Model", "F-150");
            tempCar = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();
            Guid tempUser;
            data.myCommand.CommandText = "SELECT UserID from Users where Users.username =@user";
            data.myCommand.Parameters.AddWithValue("user", "AmyBillid");
            tempUser = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();
            addRowCustomer addrow = new addRowCustomer(data, tempUser, tempCar, this);
            addrow.ShowDialog();
        }*/

        private void ReservationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
        private void reservationBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }*/
        public void updateTable()
        {
            
            data.myCommand.CommandText = "SELECT UserID from Users where Users.username = @uname";
            data.myCommand.Parameters.AddWithValue("uname", data.usr);
            Guid userID = Guid.Parse(data.myCommand.ExecuteScalar().ToString());
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
            data.myReader.Close();
            data.myCommand.Parameters.Clear();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            //_291CarRental.Form1 form1 = new Form1();
            this.Close();
            //form1.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeRow_Click(object sender, EventArgs e)
        {
            RemoveRowCustomer removerow = new RemoveRowCustomer(this);
            removerow.ShowDialog();
        }

        private void addRow_Click_1(object sender, EventArgs e)
        {

            //the two guid are for testing purpose
            Guid tempCar = new Guid();
            data.myReader.Close();
            data.myCommand.CommandText = "SELECT VehicleID from Car where Car.[Type of Vehicle] =@Type and Car.Model =@Model";
            data.myCommand.Parameters.AddWithValue("Type", "truck");
            data.myCommand.Parameters.AddWithValue("Model", "F-150");
            tempCar = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();
            //Guid tempUser;
            //data.myCommand.CommandText = "SELECT UserID from Users where Users.username =@user";
            //data.myCommand.Parameters.AddWithValue("user", "AmyBillid");
            //tempUser = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();
            addRowCustomer addrow = new addRowCustomer(data, carID, this);
            addrow.ShowDialog();
        }
    }
}
