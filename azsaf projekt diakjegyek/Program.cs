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
        Console.Write("Válassz egy tantárgyat (ékezet használata nélkül add meg a tantárgy nevét!): ");
        string tantargyinput = Console.ReadLine().ToLower();
        atlagkiiras(tantargyinput);

        //matek
        //magyar
        //töri
        //természettudomány
        //tesi
        //angol
        //info
    }

    private static void atlagkiiras(string tantargy)
    {
        double atlag = 0;
        if (tantargy == "matek" || tantargy == "matematika")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Matekjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " átlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "magyar")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Magyarjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " átlag: " + Math.Round(atlag, 2));
        }

        else if (tantargy == "tortenelem")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Tortenelemjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " átlag: " + Math.Round(atlag, 2));
        }

        else if (tantargy == "termeszettudomany")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Termeszettudomanyjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " átlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "testneveles")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Testnevelesjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " átlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "angol")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Angoljegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " átlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "informatika")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Informatikajegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " átlag: " + Math.Round(atlag, 2));
        }
        else {
            Console.WriteLine("Nincs ilyen tantárgy az adatbázisban.");
        }







        
    }

    private static void adatbetoltes(DataTable adatok)
    {
        foreach (DataRow rows in adatok.Rows)
        {
            diakjegyek jegy = new diakjegyek();
            jegy.Id = rows.Field<int>(0);  //itt lehet a hiba
            jegy.Nev = rows.Field<string>(1);
            jegy.Matekjegy=Convert.ToDouble(rows.Field<decimal>(2));
            jegy.Magyarjegy = Convert.ToDouble(rows.Field<decimal>(3));
            jegy.Tortenelemjegy = Convert.ToDouble(rows.Field<decimal>(4));
            jegy.Termeszettudomanyjegy = Convert.ToDouble(rows.Field<decimal>(5));
            jegy.Testnevelesjegy = Convert.ToDouble(rows.Field<decimal>(6));
            jegy.Angoljegy = Convert.ToDouble(rows.Field<decimal>(7));
            jegy.Informatikajegy = Convert.ToDouble(rows.Field<decimal>(8));

            diakjegyeklist.Add(jegy);
            //Console.WriteLine(jegy._Nev); //hibateszt
        }
        
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