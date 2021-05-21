using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Rezervacija
    {
        public string Name { set; get; }
        public Masa Table { set; get; }

        public Rezervacija(string name, Masa m)
        {
            Name = name;
            Table = m;
        }
    }
}
