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
    public partial class DodadiNaracka : Form
    {
        public Masa myMasa;
        public List<Naracka> tmpNaracki;
        public DodadiNaracka(Masa m)
        {
            InitializeComponent();
            myMasa = m;
            tmpNaracki = new List<Naracka>();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodadiNaracka_Load(object sender, EventArgs e)
        {
            cbArtikli.Items.Clear();
            List<Artikal> artikli = Lokal.getArtikli();
            foreach(Artikal a in artikli)
            {
                cbArtikli.Items.Add(a);
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            lbNaracka.
            tmpNaracki.Add(new )
            
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            VnesiLozinkaKelner forma = new VnesiLozinkaKelner();
            if(forma.ShowDialog() == DialogResult.OK)
            {
                myMasa.Naracka.Ime = tbIme.Text;
                foreach()
                if (myMasa.Naracka.poracaniArtikli.ContainsKey((Artikal)cbArtikli.SelectedItem))
                {
                    myMasa.Naracka.poracaniArtikli[(Artikal)cbArtikli.SelectedItem] = int.Parse(tbKolicina.Text);
                }
                else
                {
                    myMasa.Naracka.poracaniArtikli.Add((Artikal)cbArtikli.SelectedItem, int.Parse(tbKolicina.Text));
                }
            }
        }


    }
}
