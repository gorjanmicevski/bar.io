using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Sanker
    {
        public string Name { set; get; }
        public List<Naracka> Orders { set; get; }

        public Sanker(string name)
        {
            Name = name;
            Orders = new List<Naracka>();
        }
    }
}
