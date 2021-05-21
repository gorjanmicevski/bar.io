using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bar.io
{
    public partial class RabotiNaDen : Form
    {
        String date;
        public RabotiNaDen(String str)
        {
            date = str;
            InitializeComponent();
        }

        private void RabotiNaDen_Load(object sender, EventArgs e)
        {
            if (Menadzer.Reservations.ContainsKey(date))
            {
                foreach(Rezervacija r in Menadzer.Reservations[date])
                {
                    lbRezervacii.Items.Add(r);
                }
            }
            else
            {
                Menadzer.Reservations.Add(date, new List<Rezervacija>());
            }
        }
    }
}
