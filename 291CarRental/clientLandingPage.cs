﻿using System;
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
    public partial class clientLandingPage : Form
    {
        public database datab;
        private string user;
        public clientLandingPage(database temp)
        {
            InitializeComponent();
            datab = temp;
            user = datab.usr;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            /*
             * Profile Form goes here
             */
            Profile profile = new Profile(datab);
            profile.ShowDialog();
        }

        private void checkCarButton_Click(object sender, EventArgs e)
        {
            Car_Renting_Software.CarRentalPageCustomer car = new Car_Renting_Software.CarRentalPageCustomer(datab);
            car.ShowDialog();
            
        }

        private void currentRentalButton_Click(object sender, EventArgs e)
        {
            clientRentals rents = new clientRentals(datab);
            rents.ShowDialog();
            /*
            currentRentals currRent = new currentRentals(datab);
            currRent.ShowDialog();
            */
        }
    }
}
