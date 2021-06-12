using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Naracka
    {
        public string Ime { set; get; }
        
        public bool aktivna { set; get; }

        public Dictionary<Artikal, int> poracaniArtikli { set; get; }
        public Naracka()
        {
            aktivna = true;
            Ime = "";
            poracaniArtikli = new Dictionary<Artikal, int>();
        }
        public void updatePoracaniArtikli(Artikal a ,int kolicina)
        {
            if(poracaniArtikli.ContainsKey(a))
            {
                poracaniArtikli[a] = kolicina;
            }
            else
            {
                poracaniArtikli.Add(a, kolicina);
            }
        }

        public override string ToString()
        {
            StringBuilder strout= new StringBuilder();
            string pom = aktivna ? "da" : "ne";
            strout.Append(String.Format("Маса: {0} \n Aktivna: {1}, Artikli: ", Ime, pom));
            foreach(var par in poracaniArtikli)
            {
                strout.Append(String.Format("{0}: {1},",par.Key,par.Value));
            }
            return strout.ToString();
        }
    }
}
