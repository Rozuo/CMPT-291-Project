﻿using System;
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
    public partial class Reservation : Form
    {
        public _291CarRental.database data;
        public Reservation(_291CarRental.database data)
        {
            InitializeComponent();
            this.data = data;
            
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291GroupProjectDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this._291GroupProjectDataSet.Reservation);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

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
            data.myCommand.Parameters.AddWithValue("user", data.usr);
            tempUser = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();
            addRow addrow = new addRow(data, tempUser, tempCar, this);
            addrow.ShowDialog();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //_291CarRental.Form1 form1 = new Form1();
            this.Close();
            //form1.Show();
        }

        private void ReservationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
        private void reservationBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }*/
        public void updateTable()
        {
            /*data.myConnection.Close();
            data.myConnection.Open();*/
            reservationTableAdapter.Fill(_291GroupProjectDataSet.Reservation);
        }
    }
}
