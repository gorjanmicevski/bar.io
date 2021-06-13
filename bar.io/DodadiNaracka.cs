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
        public bool uredi;
        public Dictionary<Artikal,int> dikshneri { get; set; }
        public DodadiNaracka(Masa m, Kelner kelner)
        {
            InitializeComponent();
            uredi = false;
            myMasa = m;
            k = kelner;
            dikshneri = new Dictionary<Artikal, int>();
            tmpNaracki = new List<Naracka>();
            updateDict();
            updateList();
        }
        private void updateDict()
        {
            if (myMasa.Naracka.poracaniArtikli != null && myMasa.Naracka.poracaniArtikli.Count != 0)
            {
                dikshneri = myMasa.Naracka.poracaniArtikli;
            }
        }
        private void DodadiNaracka_Load(object sender, EventArgs e)
        {
            tbIme.Text = myMasa.Id.ToString();
            cbArtikli.Items.Clear();
            List<Artikal> artikli = Lokal.getArtikli();
            foreach(var a in myMasa.Naracka.poracaniArtikli)
            {
                cbArtikli.Items.Add(a.Key);
            }
            foreach(Artikal a in artikli)
            {
                cbArtikli.Items.Add(a);
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {

            if (tbIme.Text.Length==0 || cbArtikli.SelectedItem==null || tbKolicina.Text.Length == 0)
            {
                MessageBox.Show("Не Ви е целосно пополнета пријавата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                int pom1;
                if (!Int32.TryParse(tbKolicina.Text, out pom1))
                {
                    MessageBox.Show("Невалиден влез во последното поле!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else {
                    if (dikshneri.ContainsKey((Artikal)cbArtikli.SelectedItem))
                    {
                        dikshneri.Remove((Artikal)cbArtikli.SelectedItem);

                    }
                    dikshneri.Add((Artikal)cbArtikli.SelectedItem, Int32.Parse(tbKolicina.Text));
                    updateList();
                }
            }
            
        }
        private void updateList()
        {
            lbNaracka.Items.Clear();

            foreach (Artikal a in dikshneri.Keys)
            {
                string toAdd = a + "-" + dikshneri[a];
                lbNaracka.Items.Add(toAdd);
            }
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            VnesiLozinkaKelner forma = new VnesiLozinkaKelner(k);
            if(forma.ShowDialog() == DialogResult.OK)
            {
                myMasa.Naracka.Ime = tbIme.Text;
                myMasa.Naracka.poracaniArtikli = dikshneri;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
