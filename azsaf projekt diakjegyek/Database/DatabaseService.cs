using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbazis01.Database
{
    internal class DatabaseService
    {
        private static string connectionString;
        private static string table;
        private static string query_parameters;

        public static void DbConnectionCheck(string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Sikeres adatbázis kapcsolat!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sikeres kapcsolódás");
                Console.WriteLine(ex);
            }
        }

        public static DataTable GetAllData(string tableName, string connectionString)
        {//1. kell egy kapcsolódás
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            //kell egy parancs
            using var command = new MySqlCommand("select * from " + tableName, connection);
            //parancs eredményének feldolgozása
            using var reader = command.ExecuteReader();
            //adatszerkezet létrehozása
            var dataTable = new DataTable();
            //adatszerkezetbe betöltjük az adatokat
            dataTable.Load(reader);
            return dataTable;
        }
       



    }
}
