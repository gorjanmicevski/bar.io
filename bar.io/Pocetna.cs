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
        List<Sanker> sankeri = new List<Sanker>();
        List<Menadzer> menadzeri = new List<Menadzer>();
        List<Kelner> kelneri = new List<Kelner>();

        public Pocetna()
        {
            InitializeComponent();
            
        }

        private void btnNajavaMenadzer_Click(object sender, EventArgs e)
        {
            NajavaMenadzer forma = new NajavaMenadzer();
            if(forma.ShowDialog() == DialogResult.OK)
            {
                if(forma.m != null)
                {
                    PocetnaMenadzer forma1 = new PocetnaMenadzer(forma.m);
                    if (forma1.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
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
                if (forma.sanker != null)
                {
                    sankeri.Add(forma.sanker);
                }
                else
                {
                    MessageBox.Show("Не успешно е најавен шанкерот,пробај пак!", "Грешка при најава", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
