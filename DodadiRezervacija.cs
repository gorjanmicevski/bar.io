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
    public partial class DodadiRezervacija : Form
    {
        public Rezervacija myRezervacija;
        public Masa myMasa;
        public String datum;
        public DodadiRezervacija(String date)
        {
            datum = date;
            InitializeComponent();
        }

        private void DodadiRezervacija_Load(object sender, EventArgs e)
        {
            if(Menadzer.AvailableTables[datum].Count == 0)
            {
                btnDodadi.Enabled = false;
            }
            foreach(Masa m in Menadzer.AvailableTables[datum])
            {
                cbMasa.Items.Add(m);
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            myRezervacija = new Rezervacija(tbIme.Text, (Masa)cbMasa.SelectedItem);
            myMasa = (Masa)cbMasa.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
