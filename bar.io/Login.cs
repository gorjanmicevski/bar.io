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
    public partial class Login : Form
    {
        List<Menadzer> listaMenadzeri;
        public Login()
        {
            InitializeComponent();
            listaMenadzeri = new List<Menadzer>();
        }

        private void btnNajavaMenadzer_Click(object sender, EventArgs e)
        {
            NajavaMenadzer forma1 = new NajavaMenadzer();
            if (forma1.ShowDialog() == DialogResult.OK)
            {
                listaMenadzeri.Add(forma1.m);
            }
        }

        private void btnNajavaKelner_Click(object sender, EventArgs e)
        {

        }
    }
}
