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
                Menadzer.AvailableTables.Add(date, new List<Masa>());
                List<Masa> masi = new List<Masa>(5) { new Masa(1, 5), new Masa(2, 5), new Masa(3, 5), new Masa(4, 5), new Masa(5, 5) };
                Menadzer.AvailableTables[date]=masi;

            }
        }

        private void btnDodadiRezervacija_Click(object sender, EventArgs e)
        {
            DodadiRezervacija forma = new DodadiRezervacija(date);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                Rezervacija r = forma.myRezervacija;
                Masa m = forma.myMasa;
                Menadzer.Reservations[date].Add(r);
                Menadzer.AvailableTables[date].Remove(m);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
