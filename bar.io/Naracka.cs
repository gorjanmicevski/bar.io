using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Naracka
    {
        public string Ime;
        public Dictionary<Artikal, int> poracaniArtikli { set; get; }

        public Naracka()
        {
            Ime = "";
            poracaniArtikli = new Dictionary<Artikal, int>();
        }

    }
}
