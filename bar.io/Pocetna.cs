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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnNajavaMenadzer_Click(object sender, EventArgs e)
        {
            NajavaMenadzer forma = new NajavaMenadzer();
            if(forma.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnNajavaKelner_Click(object sender, EventArgs e)
        {
            NajavaKelner forma = new NajavaKelner();
            if (forma.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnNajavaSanker_Click(object sender, EventArgs e)
        {
            NajavaSanker forma = new NajavaSanker();
            if (forma.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
