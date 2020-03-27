using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


/* database class created by Alex Creencia, March 26 2020
 * 
 * **NOTE: database class is heavily based on code provided by Dr. Mohamad El-Hajj
 *  
 *  PUBLIC VARIABLE                 DESCRIPTION
 *  
 *  myConnection                    an SqlConnection that contains the connection to the database, this is put in a separate class to maintain the connection between forms
 *  myCommand                       an SqlCommand that is read as an SQL query, because we are sending it to SQL for insert record requests
 *  myReader                        an SqlReader that converts strings to commands that SQL can read
 *  usr                             holds the username of the current user
 */

namespace _291CarRental
{
    public class database 
    {
        
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string usr;
        public database(string username)
        {
            /*
             * Change the myConnection line to include whatever data connection string works with your own local database
             */
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-I3IEL2R;Initial Catalog=291GroupProject;Integrated Security=True");
            myConnection.Open();    // opens the connection
            usr = username;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Links the command stream and the connection
            this.myConnection = myConnection;
        }
        public database()
        {
            /*
             * Method invoked only once, in order to register a new client, as they will not have a username yet
             */
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-I3IEL2R;Initial Catalog=291GroupProject;Integrated Security=True");
            myConnection.Open();    // opens the connection
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Links the command stream and the connection
            this.myConnection = myConnection;
        }
        public void insert(string command)
        {
            myCommand.CommandText = command;
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }

        public void query(string command)
        {
            /*
             * because we are expecting something to be returned, we have to make a query function
             * the reader object will hold all the information obtained from the query, thus if it is to be displayed, it will be from the myReader object
             */
            myCommand.CommandText = command;
            MessageBox.Show(myCommand.CommandText);
            myReader = myCommand.ExecuteReader();
        }
    }
}
