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
        DBCheck(connectionString);
        SelectFromTable("diakokjegyek12data", connectionString);
        adatbetoltes(adatok);
        while (true)
        {
            //╰(*°▽°*)╯

            
            //selectfromtable itt volt
             //adatbetoltés itt volt
            Console.Write("Melyik tantárgy osztályátlagát szeretné megtekinteni? ");
            string tantargyinput = Console.ReadLine().ToLower();
            atlagkiiras(tantargyinput);
            Console.WriteLine();

            //matek
            //magyar
            //töri
            //természettudomány
            //tesi
            //angol
            //info

            Console.Write("Irassunk ki mindent? (igen/nem) ");
            string igennem = Console.ReadLine().ToLower();
            bool kiiras = (igennem == "igen") ? true : false;
            if (kiiras)
            {
                kiiratas(diakjegyeklist);
                Console.WriteLine();
            }

            nevekatlaguk(diakjegyeklist);

            Console.WriteLine();

            Console.WriteLine("Szeretne törölni diákot a listából? (igen/nem) ");  //--------------------------------------------------------------------------------Tesztelni
            string igennem2 = Console.ReadLine().ToLower();
            if (igennem2 == "igen")
            {
                Console.WriteLine("Adja meg a diák ID-ját: ");

                int torolId = Convert.ToInt32( Console.ReadLine());
                for (int i = 0; i < diakjegyeklist.Count; i++)
                {
                    if (diakjegyeklist[i].Id == torolId)
                    {
                        diakjegyeklist.RemoveAt(i);
                    }
                }
                {
                   
                }

            }
            //-------------------------------------------------------------------------------------------------------------------------------------------
        }
        nevek

        

        

    }

    private static void nevekatlaguk(List<diakjegyek> diakjegyeklist)
    {
        Console.Write("Kinek a jegyeit szeretné megnézni? ");
        string keresettnev = Console.ReadLine().ToLower();
        Console.WriteLine();
        bool vanediak = false;
        foreach (var item in diakjegyeklist)
        {
            if (item.Nev.ToLower() == keresettnev)
            {
                vanediak=true;
                Console.WriteLine($"{item.Nev}");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Matematika: {item.Matekjegy}");
                Console.WriteLine($"Magyar: {item.Magyarjegy}");
                Console.WriteLine($"Történelem: {item.Tortenelemjegy}");
                Console.WriteLine($"Természettudomány: {item.Termeszettudomanyjegy}");
                Console.WriteLine($"Testnevelés: {item.Testnevelesjegy}");
                Console.WriteLine($"Angol: {item.Angoljegy}");
                Console.WriteLine($"Informatika: {item.Informatikajegy}");
            }
        }
        if ( vanediak == false)
        {
            Console.WriteLine("Nincs ilyen nevű diák az adatbázisban.");
        }
    }

    private static void kiiratas(List<diakjegyek> diakjegyeklist)
    {
        foreach (var item in diakjegyeklist) 
        {
            Console.WriteLine(item.ToString());
        }
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
            Console.WriteLine(tantargy + " osztályátlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "magyar")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Magyarjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " osztályátlag: " + Math.Round(atlag, 2));
        }

        else if (tantargy == "tortenelem" || tantargy == "történelem")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Tortenelemjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " osztályátlag: " + Math.Round(atlag, 2));
        }

        else if (tantargy == "termeszettudomany" || tantargy == "természettudomány")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Termeszettudomanyjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " osztályátlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "testneveles" || tantargy == "testnevelés")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Testnevelesjegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " osztályátlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "angol")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Angoljegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " osztályátlag: " + Math.Round(atlag, 2));
        }
        else if (tantargy == "informatika")
        {
            foreach (var jegy in diakjegyeklist)
            {
                atlag += jegy.Informatikajegy;
            }
            atlag = atlag / diakjegyeklist.Count;
            Console.WriteLine(tantargy + " osztályátlag: " + Math.Round(atlag, 2));
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