using adatbazis01.Database;
using azsaf_projekt_diakjegyek.Model;
using System.Data;
using System.Security.Cryptography.X509Certificates;
internal class Program
{

    //connection adatai
    public static readonly string connectionString = "Server=localhost;Database=11adiakok;User=root;"; 

    public static DataTable adatok = new DataTable();
    public static List<diakjegyek> diakjegyeklist = new List<diakjegyek>();
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); //╰(*°▽°*)╯

        DBCheck(connectionString);
        SelectFromTable("diakokjegyek12data", connectionString);
        adatbetoltes(adatok);
    }

    private static void adatbetoltes(DataTable adatok)
    {
        foreach (DataRow rows in adatok.Rows)
        {
            diakjegyek jegy = new diakjegyek();
            jegy._Id = rows.Field<int>(0);  //itt lehet a hiba
            jegy._Nev = rows.Field<string>(1);
            jegy._Matekjegy=Convert.ToDouble(rows.Field<decimal>(2));
            jegy._Magyarjegy = Convert.ToDouble(rows.Field<decimal>(3));
            jegy._Tortenelemjegy = Convert.ToDouble(rows.Field<decimal>(4));
            jegy._Termeszettudomanyjegy = Convert.ToDouble(rows.Field<decimal>(5));
            jegy._Testnevelesjegy = Convert.ToDouble(rows.Field<decimal>(6));
            jegy._Angoljegy = Convert.ToDouble(rows.Field<decimal>(7));
            jegy._Informatikajegy = Convert.ToDouble(rows.Field<decimal>(8));

            diakjegyeklist.Add(jegy);
            Console.WriteLine(jegy._Id); //hibateszt
        }
        Console.WriteLine(diakjegyeklist);
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