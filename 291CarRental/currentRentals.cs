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
    public partial class currentRentals : Form
    {

        private int theSelectedRow;
        private int amountOfRows;
        private string[] dataString;
        public database data;

        public currentRentals(database data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void groupProjectDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void currentRentals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291GroupProjectDataSetReservation.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this._291GroupProjectDataSetReservation.Reservation);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            //generate a report
            Report rep = new Report(data);
            rep.ShowDialog();
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //CarInfoBox.Clear();
                theSelectedRow = e.RowIndex;
                amountOfRows = dataGridViewReservation.SelectedRows.Count;
                //string[] columnHeaders = new string[dataGridViewReservation.Columns.Count];


                foreach (DataGridViewRow theRow in dataGridViewReservation.SelectedRows)
                {
                    for (int i = 0; i < dataString.Length; i++)
                    {
                        dataString[i] = theRow.Cells[i].Value.ToString();
                        //columnHeaders[i] = CarData.Columns[i].HeaderText;
                    }
                }
            }
        }
    }
}
