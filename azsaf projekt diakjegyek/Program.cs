using adatbazis01.Database;
using System.Data;
using System.Security.Cryptography.X509Certificates;
internal class Program
{

    //connection adatai
    public static readonly string connectionString = "Server=localhost;Database=11adiakok;User=root;"; 

    public static DataTable adatok = new DataTable();
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); //╰(*°▽°*)╯

        DBCheck(connectionString);
        SelectFromTable("diakokjegyek12data", connectionString);


    }

    public static void SelectFromTable(string tableName, string connectionString)
    {
        adatok = DatabaseService.GetAllData(tableName, connectionString);
    }

    private static void DBCheck(string connectionString)
    {
        DatabaseService.DbConnectionCheck(connectionString);
    }
}