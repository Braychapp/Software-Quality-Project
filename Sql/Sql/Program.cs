using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=localhost;uid=root;pwd=putpasswordhere;database=app;port=3306";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                SQL hi = new SQL(conn);
                Console.WriteLine(hi.Login("users", "Hi123@gmail.com", "123abc"));
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
