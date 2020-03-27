using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting_Software
{
    public partial class Form1 : Form
    {

        private string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void carIDBox_TextChanged(object sender, EventArgs e)
        {

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

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void modelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
