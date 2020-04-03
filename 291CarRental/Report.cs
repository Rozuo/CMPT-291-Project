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

    

    public partial class Report : Form
    {
        private database data;
        private string cmd;
        private Guid mostBranch;
        private string mostLocation;
        private decimal  mostMoney;
        private int mostReservation;

        public Report(database data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            cmd = "Select BranchID from (Select TOP 1(count(BranchID)) as totalBranch, BranchID from Reservation group by BranchID order by totalBranch desc) as temp";
            data.myCommand.CommandText = cmd;
            mostBranch = (Guid) data.myCommand.ExecuteScalar();
            data.clearParameters();
            
            cmd = "Select Location from Branch where BranchID = @branch";
            data.myCommand.Parameters.AddWithValue("branch", mostBranch.ToString());
            data.myCommand.CommandText = cmd;
            mostLocation = (string) data.myCommand.ExecuteScalar();
            MessageBox.Show(mostBranch.ToString());
            data.clearParameters();
            labelMostBranch.Text = mostLocation;

            cmd = "Select max([Total Price]) from Reservation";
            data.myCommand.CommandText = cmd;
            mostMoney = (decimal) data.myCommand.ExecuteScalar();
            labelMostMoney.Text = mostMoney.ToString();
            data.clearParameters();

            cmd = "Select totalBranch from (Select TOP 1(count(BranchID)) as totalBranch, BranchID from Reservation group by BranchID order by totalBranch desc) as temp";
            data.myCommand.CommandText = cmd;
            mostReservation = (int) data.myCommand.ExecuteScalar();
            labelMostReservation.Text = mostReservation.ToString();
        }
    }
}
