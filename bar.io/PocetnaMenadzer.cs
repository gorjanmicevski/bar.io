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
    public partial class PocetnaMenadzer : Form
    {
        public Menadzer menadzer;
        public PocetnaMenadzer(Menadzer m)
        {
            menadzer = m;
            InitializeComponent();
        }

        private void PocetnaMenadzer_Load(object sender, EventArgs e)
        {
            label2.Text = String.Format("Добредојдовте {0}!", menadzer.Name);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            String date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            RabotiNaDen forma = new RabotiNaDen(date);
            if (forma.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
