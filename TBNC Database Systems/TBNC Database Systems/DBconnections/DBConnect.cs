using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Add MySql Library
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using TBNC_Database_Systems.DBconnections;

namespace TBNC_Database_Systems.Main
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "arlia.computing.dundee.ac.uk";
            database = "12ac3d28";
            uid = "12ac3u28";
            password = "111abc";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                Console.WriteLine(ex.ToString());
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<string> SelectAllParents()
        {
            string query = "SELECT * FROM parentsList_view";
            List<string> list = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, this.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["Parent_ID"]+"");
                    list.Add(dataReader["First_Name"]+ "");
                    list.Add(dataReader["Surname"]+ "");
                    list.Add(dataReader["Gender"]+ "");
                    list.Add(dataReader["Address_ID"]+ "");                    
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Insert statement
        public int InsertReturnAddress(string number, string name, string line, string town, string county, string postcode, string country)
        {
            int address = -1;
            string query = "CALL addAddress_prc('" + number + "','" + name + "','" + line + "', '" + town + "', '" + county + "', '" + postcode + "', '" + country + "');";

            string query2 = "SELECT Address_ID FROM address ORDER BY Address_ID ASC LIMIT 1;";
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand(query2, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

                address = Convert.ToInt32(dataReader["Address_ID"]);

                //close connection
                this.CloseConnection();
            }
            return address;
        }

        public Address SelectAddress(int id)
        {
            string query = "SELECT * FROM address WHERE Address_ID="+ id + ";";
            List<string> list = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, this.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["Address_ID"] + "");
                    list.Add(dataReader["Street_Number"] + "");
                    list.Add(dataReader["Street_Name"] + "");
                    list.Add(dataReader["Address_Line_2"] + "");
                    list.Add(dataReader["Town"] + "");
                    list.Add(dataReader["County"] + "");
                    list.Add(dataReader["Postcode"] + "");
                    list.Add(dataReader["Country"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return new Address(list);
            }
            else
            {
                return new Address(list);
            }
        }

        //Insert statement
        public void InsertAddress(string number, string name, string line, string town, string county, string postcode, string country)
        {
            string query = "CALL addAddress_prc('" + number + "','" + name + "','" + line + "', '" + town + "', '" + county + "', '" + postcode + "', '" + country + "');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void InsertChild(Address mAddress, ChildRecord mChildRecord, Child mChild)
        {
            string query = "CALL addAddress_prc('" + mAddress.Number + "','" + mAddress.Name + "','" + mAddress.Line2 + "', '" + mAddress.Town + "', '" + mAddress.County + "', '" + mAddress.Postcode + "', '" + mAddress.Country + "');";
            
            string query2 = "CALL addChildRecord_prc('" + mAddress.Number + "','" + mAddress.Name + "','" + mAddress.Line2 + "', '" + mAddress.Town + "', '" + mAddress.County + "', '" + mAddress.Postcode + "', '" + mAddress.Country + "');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand(query2, connection);

                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void InsertChild(int address, DateTime _Start_Date, double _Regular_Days, int _Department_ID, double _Deposit_Amount, int paid_back, 
            string _First_Name, string _Surname, char _Gender, DateTime _DOB)  
        {
            int record = -1;

            string query = "CALL addChildRecord_prc(" + _Start_Date + "," + _Regular_Days + "," + _Department_ID + ", " + _Deposit_Amount + ", " + paid_back + ");";

            string query2 = "SELECT ChildRecord_ID FROM child_record ORDER BY ChildRecord_ID ASC LIMIT 1;";

            string query3 = "CALL addChild_prc('" +_First_Name + "','" + _Surname + "','" + _Gender + "', " + _DOB + ", " + record + ", "+ address +");";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand(query2, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

                record = Convert.ToInt32(dataReader["ChildRecord_ID"]);

                cmd = new MySqlCommand(query3, connection);

                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        /*
        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
         */
    }
}
