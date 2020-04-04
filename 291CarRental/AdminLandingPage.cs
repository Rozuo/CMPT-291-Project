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
    public partial class AdminLandingPage : Form
    {
        public database data;
        public AdminLandingPage(database data)
        {
            InitializeComponent();
            this.data = data;
        }



        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportButtons_Click(object sender, EventArgs e)
        {
            currentRentals currRents = new currentRentals(data);
            currRents.ShowDialog();
        }

        private void processRentalButton_Click(object sender, EventArgs e)
        {
            Car_Renting_Software.Form4 carRenting = new Car_Renting_Software.Form4(data);
            carRenting.ShowDialog();
        }

        private void processReturnsButton_Click(object sender, EventArgs e)
        {
            ProcessReturns returs = new ProcessReturns(data);
            returs.ShowDialog();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            addVehicle add = new addVehicle(data);
            add.ShowDialog();
        }
    }
}
