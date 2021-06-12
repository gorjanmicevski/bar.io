using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Artikal
    {
        public string Ime { get; set; }
        public int Cena { get; set; }
        public Artikal(string ime, int cena)
        {
            Ime = ime;
            Cena = cena;
        }
        public override string ToString()
        {
            return String.Format("{0} ({1} денари) \n", Ime, Cena);
        }

    }
}
