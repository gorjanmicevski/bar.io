using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Kelner
    {
        public string Name { set; get; }
        public List<Masa> Tables { set; get; }

        public Kelner(string name)
        {
            Name = name;
            Tables = new List<Masa>();
        }
    }
}
