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
    public partial class IzberiDen : Form
    {
        public Menadzer m;
        public IzberiDen(Menadzer menadzer)
        {
            m = menadzer;
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime data = monthCalendar1.SelectionRange.Start;
            string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            RabotiNaDen forma = new RabotiNaDen(date, data);
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
