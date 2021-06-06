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
                kelner.Tables.Add(m);
                DodadiNaracka forma1 = new DodadiNaracka(m);

            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
                
