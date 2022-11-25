using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Sql
{

    internal class SQL
    {
        public MySqlConnection conn { get; set; }

        public SQL(MySqlConnection conn)
        {
            this.conn = conn;
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Check port and IP to see if correct...");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password");
                        break;
                    default: Console.WriteLine(ex.Number.ToString()); break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error {0}: {1}", ex.Number.ToString(), ex.Message);
                return false;
            }
        }
        public string Login(string user, string email, string password)
        {
            string countquery = "SELECT COUNT(*) FROM " + user + " WHERE Email='" + email + "'";
            string query = "SELECT Email FROM " + user + " WHERE Email='" + email + "' AND Password='"+password+"'";
            if (OpenConnection())
            {
                MySqlCommand ifExists = new MySqlCommand(countquery, conn);
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (Convert.ToInt32(ifExists.ExecuteScalar()) != 1)
                {
                    CloseConnection();
                    return "Invalid Credentials or Account Not Registered";
                }
                else
                {
                    CloseConnection();
                    return "Logged In!";
                }
            }
            else
            {
                return "Did Not Connect";
            }
        }

        public string Register(string user, string email, string data)
        {
            string countquery = "SELECT COUNT(*) FROM " + user + " WHERE Email='" + email + "'";
            string getID = "SELECT COUNT(*) FROM " + user;

            MySqlCommand ifExists = new MySqlCommand(countquery, conn);
            MySqlCommand ID = new MySqlCommand(getID, conn);
            if (OpenConnection())
            {
                if (Convert.ToInt32(ifExists.ExecuteScalar()) == 0)
                {
                    CloseConnection();
                    return "Account Already Registered, Please log in...";
                }
                else
                {
                    int currentID = Convert.ToInt32(ID.ExecuteScalar())+1;
                    string query = "INSERT INTO " + user + " (" + currentID.ToString() + ", " + data + ")";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    return "Registered";
                }
            }
            else
            {
                return "Did Not Connect";
            }
        }
    }
}
