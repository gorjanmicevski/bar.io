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
        public static List<Sanker> sankeri = new List<Sanker>();
        public static List<Menadzer> menadzeri = new List<Menadzer>();
        public static List<Kelner> kelneri = new List<Kelner>();

        public Pocetna()
        {
            InitializeComponent();
            Lokal l = new Lokal();
            
            
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
                
                PocetnaKelner forma1 = new PocetnaKelner(forma.k);
                //Smeniv tuka od OK vo Cancel 
                if (forma1.ShowDialog() == DialogResult.Cancel)
                {
                    kelneri.Add(forma1.kelner);
                }
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
                    PocetnaSanker form2 = new PocetnaSanker();
                    if(form2.ShowDialog() == DialogResult.OK)
                    {

                    }
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
