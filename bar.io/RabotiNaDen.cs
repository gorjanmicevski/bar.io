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
        string date;
        DateTime data;
        
        public RabotiNaDen(string str,DateTime data)
        {
            date = str;
            this.data = data;
            InitializeComponent();
        }

        private void RabotiNaDen_Load(object sender, EventArgs e)
        {
            if (Lokal.Reservations != null)
            {
                if (Lokal.Reservations.ContainsKey(date))
                {
                    foreach (Rezervacija r in Lokal.Reservations[date])
                    {
                        lbRezervacii.Items.Add(r);
                    }
                }
                else
                {
                    Lokal.Reservations.Add(date, new List<Rezervacija>());
                    Lokal.AvailableTables.Add(date, new List<Masa>());
                    List<Masa> masi = new List<Masa>(5) { new Masa(1, 5), new Masa(2, 5), new Masa(3, 5), new Masa(4, 5), new Masa(5, 5) };
                    Lokal.AvailableTables[date] = masi;

                }
            }
        }

        private void btnDodadiRezervacija_Click(object sender, EventArgs e)
        {
            DodadiRezervacija forma = new DodadiRezervacija(date);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                Rezervacija r = forma.myRezervacija;
                Masa m = forma.myMasa;
                Lokal.Reservations[date].Add(r);
                Lokal.AvailableTables[date].Remove(m);
                lbRezervacii.Items.Add(r);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbRezervacii.SelectedItem != null)
            {
                Rezervacija r = (Rezervacija)lbRezervacii.SelectedItem;
                Lokal.Reservations[date].Remove(r);
                //Lokal.AvailableTables[date].Remove(m);
                lbRezervacii.Items.Remove(r);
            }
            else
            {
                MessageBox.Show("Немате селектирано резервација за бришење!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
