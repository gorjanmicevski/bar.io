using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Lokal
    {
        public static int tableCount {set;get;}
        public static Dictionary<string, List<Rezervacija>> Reservations { set; get; }
        public static Dictionary<string, List<Masa>> AvailableTables { get; set; }
        public static Dictionary<Artikal, int> Artikli = new Dictionary<Artikal, int>{ {new Artikal("Coca-Cola",20),10 }, { new Artikal("Sprite", 20), 10 } , { new Artikal("Fanta", 20), 10 }, { new Artikal("Malo Makijato", 20), 10 }, { new Artikal("Golemo Makijato", 20), 10 } };
        public Lokal()
        {
            tableCount = 5;
            Reservations = new Dictionary<string, List<Rezervacija>>();
            AvailableTables = new Dictionary<string, List<Masa>>();
            
        }
        public static List<Artikal> getArtikli()
        {
            List<Artikal> artikli = new List<Artikal>();
            if (Artikli!=null)
            {
                foreach (var a in Artikli.Keys)
                {
                    artikli.Add(a);
                }
            }
            return artikli;
        }
        
    }
}
