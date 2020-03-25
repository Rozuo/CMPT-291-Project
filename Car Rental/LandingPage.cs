using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void client_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage landingForm = new LandingPage();
            landingForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Reservation reservationForm = new Reservation();
            reservationForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            Client clientForm = new Client();
            clientForm.ShowDialog();
        }
    }
}
