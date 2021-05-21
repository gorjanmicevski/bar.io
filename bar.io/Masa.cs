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

        public Masa(int id, int availableSeats)
        {
            Id = id;
            AvailableSeats = availableSeats;
        }

        public override string ToString()
        {
            return String.Format("бр. {0} со {1} луѓе",Id, AvailableSeats);
        }
    }
}
