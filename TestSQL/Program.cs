using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQL
{
     class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=ASHARBAJI-PC\\MSSQLSERVER2;Initial Catalog=TodoListDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection Successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex.Message);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
    

