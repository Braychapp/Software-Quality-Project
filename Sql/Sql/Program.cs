using System;
using System.Collections.Generic;
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

            myConnectionString = "server=localhost;uid=root;pwd=123abc;database=app;port=3306";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Console.WriteLine("Made Connection");
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
