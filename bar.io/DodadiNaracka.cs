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
        public Kelner k;
        public List<Naracka> tmpNaracki;
        public Dictionary<Artikal,int> dikshneri { get; set; }
        public DodadiNaracka(Masa m, Kelner kelner)
        {
            InitializeComponent();
            myMasa = m;
            k = kelner;
            dikshneri = new Dictionary<Artikal, int>();
            tmpNaracki = new List<Naracka>();
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
            if (tbIme.Text.Length==0 || cbArtikli.SelectedItem==null || tbKolicina.Text.Length == 0)
            {
                MessageBox.Show("Не ви е целосно пополнета пријавата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                int pom1;
                if (!Int32.TryParse(tbKolicina.Text, out pom1))
                {
                    MessageBox.Show("Не валиден влез во последното поле!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else {
                    if (dikshneri.ContainsKey((Artikal)cbArtikli.SelectedItem))
                    {
                        dikshneri.Remove((Artikal)cbArtikli.SelectedItem);

                    }
                    dikshneri.Add((Artikal)cbArtikli.SelectedItem, Int32.Parse(tbKolicina.Text));
                    lbNaracka.Items.Clear();
                    foreach (Artikal a in dikshneri.Keys)
                    {
                        string toAdd = a + "-" + dikshneri[a];
                        lbNaracka.Items.Add(toAdd);
                    }
                    //lbNaracka.tmpNaracki.Add(new )
                    //Naracka nova = new Naracka(tbIme.Text, cbArtikli.SelectedItem, tbKolicina.Text);
                }
            }
            
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            VnesiLozinkaKelner forma = new VnesiLozinkaKelner(k);
            if(forma.ShowDialog() == DialogResult.OK)
            {
                myMasa.Naracka.Ime = tbIme.Text;
                if (myMasa.Naracka.poracaniArtikli.ContainsKey((Artikal)cbArtikli.SelectedItem))
                {
                    myMasa.Naracka.poracaniArtikli[(Artikal)cbArtikli.SelectedItem] = int.Parse(tbKolicina.Text);
                }
                else
                {
                    myMasa.Naracka.poracaniArtikli.Add((Artikal)cbArtikli.SelectedItem, int.Parse(tbKolicina.Text));
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
