using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    class Rezervacija
    {
        int ID { get; set; }
        int brojNaLugje { get; set; }
        int promet { get; set; }

        public Rezervacija(int ID,int brojNaLugje,int promet)
        {
            this.ID = ID;
            this.brojNaLugje = brojNaLugje;
            this.promet = promet;
        }
    }
}
