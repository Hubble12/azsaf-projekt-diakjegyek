using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azsaf_projekt_diakjegyek.Model
{
    internal class diakjegyek
    {

        private int _Id;
        private string _Nev;
        private double _Matekjegy;
        private double _Magyarjegy;
        private double _Tortenelemjegy;
        private double _Termeszettudomanyjegy;
        private double _Testnevelesjegy;
        private double _Angoljegy;
        private double _Informatikajegy;

        public int Id { get => _Id; set => _Id = value; }
        public string Nev { get => _Nev; set => _Nev = value; }
        public double Matekjegy { get => _Matekjegy; set => _Matekjegy = value; }
        public double Magyarjegy { get => _Magyarjegy; set => _Magyarjegy = value; }
        public double Tortenelemjegy { get => _Tortenelemjegy; set => _Tortenelemjegy = value; }
        public double Termeszettudomanyjegy { get => _Termeszettudomanyjegy; set => _Termeszettudomanyjegy = value; }
        public double Testnevelesjegy { get => _Testnevelesjegy; set => _Testnevelesjegy = value; }
        public double Angoljegy { get => _Angoljegy; set => _Angoljegy = value; }
        public double Informatikajegy { get => _Informatikajegy; set => _Informatikajegy = value; }

        public diakjegyek(int id, string nev, double matekjegy, double magyarjegy, double tortenelemjegy, double termeszettudomanyjegy, double testnevelesjegy, double angoljegy, double informatikajegy)
        {
            Id = id;
            Nev = nev;
            Matekjegy = matekjegy;
            Magyarjegy = magyarjegy;
            Tortenelemjegy = tortenelemjegy;
            Termeszettudomanyjegy = termeszettudomanyjegy;
            Testnevelesjegy = testnevelesjegy;
            Angoljegy = angoljegy;
            Informatikajegy = informatikajegy;
        }

        public diakjegyek()
        {
        }


    }
}
