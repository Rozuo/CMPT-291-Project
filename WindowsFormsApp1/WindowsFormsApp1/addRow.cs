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
    public partial class addRow : Form
    {
        private database data;
        private Guid customerID;
        private Guid CarID;
        public addRow(database data, Guid customerID, Guid CarID)
        {
            InitializeComponent();
            this.data = data;
            this.customerID = customerID;
            this.CarID = CarID;

        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmB_Click(object sender, EventArgs e)
        {
            /*add the information to the row*/
            data = new database();
            /*search for the userID*/
            Guid guid;
            data.myCommand.CommandText = "SELECT UserID from Users where Users.username =@user";
            data.myCommand.Parameters.AddWithValue("user", customerFName.Text);
            try
            {
                guid = (Guid)data.myCommand.ExecuteScalar();
                data.myCommand.Parameters.Clear();
            }
            catch
            {
                MessageBox.Show("User does not exist");
            }

            Guid guidLocation;
            data.myCommand.CommandText = "SELECT BranchID from Branch where Branch.Location =@location";
            data.myCommand.Parameters.AddWithValue("location", locationB.SelectedItem);
            guidLocation = (Guid)data.myCommand.ExecuteScalar();
            data.myCommand.Parameters.Clear();
            try
            {
                guidLocation = (Guid)data.myCommand.ExecuteScalar();
                data.myCommand.Parameters.Clear();
                Decimal price = calPrice(CarID, startTimePicker, endTimePicker);//calculate price
                /*insert the row*/
                Guid guidRev = Guid.NewGuid();
                data.myCommand.CommandText = "INSERT INTO [dbo].[Reservation] VALUES (@ReservationID, @startDate, @endDate, @price, @BranchID, @VehicleID, @UserID)";
                data.myCommand.Parameters.AddWithValue("ReservationID", guidRev);
                data.myCommand.Parameters.AddWithValue("startDate", startTimePicker.Value);
                data.myCommand.Parameters.AddWithValue("endDate", endTimePicker.Value);
                data.myCommand.Parameters.AddWithValue("price", price);
                data.myCommand.Parameters.AddWithValue("BranchID", guidLocation);
                data.myCommand.Parameters.AddWithValue("VehicleID", CarID);
                data.myCommand.Parameters.AddWithValue("UserID", customerID);
                data.myCommand.ExecuteNonQuery();
                data.myCommand.Parameters.Clear();
                //MessageBox.Show("Reservation added");
            }
             catch {
                MessageBox.Show("Please choose a city");
            }
            this.Close();
        }

        private Decimal calPrice(Guid CarId, DateTimePicker starts, DateTimePicker ends)
        {
            TimeSpan result = ends.Value - starts.Value;
            data.myCommand.CommandText = "SELECT [Type of Vehicle] from Car where Car.VehicleID =@CarID";
            data.myCommand.Parameters.AddWithValue("CarID", CarId);
            string CarType = data.myCommand.ExecuteScalar().ToString();//get the type of vehicle
            data.myCommand.Parameters.Clear();

            data.myCommand.CommandText = 
                "SELECT [Daily Price] from CarType where CarType.[Type of Vehicle] =@CarType";
            data.myCommand.Parameters.AddWithValue("CarType", CarType);
            //count as 1 day even if the customer returns it the day they rent the car
            int days = ((int)result.Days)+1;
            int dayPrice = Decimal.ToInt32((decimal)data.myCommand.ExecuteScalar());
            data.myCommand.Parameters.Clear();
            Decimal totalPrice = 0;
            if (days >= 7) {//apply the weekly discount
                data.myCommand.CommandText =
                    "SELECT [Weekly Price] from CarType where CarType.[Type of Vehicle] =@CarType";
                data.myCommand.Parameters.AddWithValue("CarType",CarType);
                Decimal multiplier = (decimal)data.myCommand.ExecuteScalar();
                totalPrice = days * dayPrice * multiplier;
                data.myCommand.Parameters.Clear();
            }else if(days >= 30){//apply the monthly discount
                data.myCommand.CommandText =
                    "SELECT [Monthly Price] from CarType where CarType.[Type of Vehicle] =@CarType";
                data.myCommand.Parameters.AddWithValue("CarType", CarType);
                Decimal multiplier = (decimal)data.myCommand.ExecuteScalar();
                totalPrice = days * dayPrice * multiplier;
                data.myCommand.Parameters.Clear();
            }
            else
            {//otherwise just calculate the price only
                totalPrice = days * dayPrice;
            }
            if (totalPrice < 0) totalPrice = 0;
            return totalPrice;
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void locationB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRow_Load(object sender, EventArgs e)
        {
        }

        private void endDateL_Click(object sender, EventArgs e)
        {

        }

        private void priceResult_Click(object sender, EventArgs e)
        {
        }

        private void resultB_Click(object sender, EventArgs e)
        {
            priceResult.Text = "Your total price is: " + calPrice(this.CarID, startTimePicker, endTimePicker);

        }
    }
}
