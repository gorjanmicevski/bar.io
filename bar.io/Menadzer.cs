using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Menadzer
    {
        string Ime { get; set; }
        string Prezime { get; set; }
        int izraboteniSaati { get; set; }
        int bonusSaati { get; set; }
        List<Rezervacija> rezervacii = new List<Rezervacija>();
        public Menadzer(string ime,string prez,int sat1,int sat2)
        {
            this.Ime = ime;
            this.Prezime = prez;
            this.izraboteniSaati = sat1;
            this.bonusSaati = sat2;
            rezervacii = new List<Rezervacija>();
        }

    }
}
