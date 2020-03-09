using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConnectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // SQL server connection string
            //SYNTAX:
            //@"Data Source=(MachineName)\(InstanceName);Initial Catalog=(DBName);Integrated Security=True;"
            //SYNTAX For SQL Server Authentication:
            //@"Data Source=(MachineName)\(InstanceName);Initial Catalog=(DBName); User ID=(UserName);Password=(Password);"
            SqlConnection sqlCon = new SqlConnection();
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
