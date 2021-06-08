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
    public partial class DodadiMasa : Form
    {
        public Masa myMasa;
        public DodadiMasa()
        {
            InitializeComponent();
        }
        private void btnDodadi_Click(object sender, EventArgs e)
        {
            myMasa = new Masa(int.Parse(tbID.Text));
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
