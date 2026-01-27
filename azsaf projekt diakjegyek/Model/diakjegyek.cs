using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azsaf_projekt_diakjegyek.Model
{
    internal class diakjegyek
    {

        public int _Id { get; set; }
        public string _Nev { get; set; }
        public double _Matekjegy { get; set; }
        public double _Magyarjegy { get; set; }
        public double _Tortenelemjegy { get; set; }
        public double _Termeszettudomanyjegy { get; set; }
        public double _Testnevelesjegy { get; set; }
        public double _Angoljegy { get; set; }
        public double _Informatikajegy { get; set; }




        public diakjegyek(int id, string nev, double matekjegy, double magyarjegy, double tortenelemjegy, double termeszettudomanyjegy, double testnevelesjegy, double angoljegy, double informatikajegy)
        {
            _Id = id;
            _Nev = nev;
            _Matekjegy = matekjegy;
            _Magyarjegy = magyarjegy;
            _Tortenelemjegy = tortenelemjegy;
            _Termeszettudomanyjegy = termeszettudomanyjegy;
            _Testnevelesjegy = testnevelesjegy;
            _Angoljegy = angoljegy;
            _Informatikajegy = informatikajegy;
        }

        public diakjegyek()
        {
        }


    }
}
