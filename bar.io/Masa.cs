using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Masa
    {
        public int Id { set; get; }
        public int AvailableSeats { set; get; }
        public Naracka Naracka { get; set; }

        public Masa(int id, int availableSeats)
        {
            Id = id;
            AvailableSeats = availableSeats;
            Naracka = new Naracka();
        }
        public Masa(int id)
        {
            Id = id;
            Naracka = new Naracka();
        }

        public override string ToString()
        {
            return String.Format("бр. {0} со {1} луѓе\n",Id, AvailableSeats);
        }

    }
}
