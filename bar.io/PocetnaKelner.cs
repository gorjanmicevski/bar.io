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
    public partial class PocetnaKelner : Form
    {
        public Kelner kelner;
        public PocetnaKelner(Kelner k)
        {
            kelner = k;
            if (k == null)
            {
                kelner = new Kelner(k.Name);
            }
            InitializeComponent();
        }

        
        private void PocetnaKelner_Load(object sender, EventArgs e)
        {
            lbMasi.Items.Clear();
            foreach (Masa m in kelner.Tables)
            {
                lbMasi.Items.Add(m);
            }
        }

        private void btnDodadiMasa_Click(object sender, EventArgs e)
        {
            DodadiMasa forma = new DodadiMasa();
            if(forma.ShowDialog() == DialogResult.OK)
            {
                Masa m = forma.myMasa;
                bool flag = false;
                foreach(Masa item in kelner.Tables)
                {
                    if (item.Id==m.Id)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    MessageBox.Show("Масате веќе постои!", "Неуспешно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    kelner.Tables.Add(m);
                    DodadiNaracka forma1 = new DodadiNaracka(m,kelner);
                    if (forma1.ShowDialog() == DialogResult.OK)
                    {
                        lbMasi.Items.Add(m);
                    }
                    
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnIzbrisiMasa_Click(object sender, EventArgs e)
        {
            if (lbMasi.SelectedItem!=null)
            {
                VnesiLozinkaMenadzer forma = new VnesiLozinkaMenadzer(Korisnici.Menadzeri);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    int index = lbMasi.SelectedIndex;
                    Masa m = (Masa)lbMasi.Items[index];//***
                    lbMasi.Items.RemoveAt(index);
                    kelner.Tables.Remove(m);//****
                    DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                MessageBox.Show( "Немате селектирано маса!", "грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnEditMasa_Click(object sender, EventArgs e)
        {
            if (lbMasi.SelectedItem != null)
            {
                Masa selektirana = (Masa)lbMasi.SelectedItem;
                DodadiNaracka forma1 = new DodadiNaracka(selektirana,kelner);
                if (forma1.ShowDialog() == DialogResult.OK)
                {

                }
                /* DodadiMasa m = new DodadiMasa();
                 m.tableToEdit((Masa)lbMasi.SelectedItem);
                 if (m.ShowDialog() == DialogResult.OK)
                 {
                     lbMasi.SelectedItem =(Masa) m.myMasa;

                     this.UpdateList();
                 }
                */
            }
            else
            {
                MessageBox.Show("Немате селектирано маса!", "грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void UpdateList()
        {
            lbMasi.Items.Clear();
            foreach(Masa m in kelner.Tables)
            {
                lbMasi.Items.Add(m);
            }
        }
    }
}
                
