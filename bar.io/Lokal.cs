using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Lokal
    {
        public static Dictionary<String, Rezervacija> Reservations { set; get; }
        public static Dictionary<int, Masa> AvailableTables { get; set; }
        public static Dictionary<Artikal, int> Artikli { get; set; }
        public Lokal()
        {
            Reservations = new Dictionary<string, Rezervacija>();
            AvailableTables = new Dictionary<int, Masa>();
            Artikli = new Dictionary<Artikal, int>();
        }
        public static List<Artikal> getArtikli()
        {
            List<Artikal> artikli = new List<Artikal>();
            foreach(Artikal a in Artikli.Keys)
            {
                artikli.Add(a);
            }
            return artikli;
        }
    }
}
