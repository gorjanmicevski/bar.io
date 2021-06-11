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
    public partial class VnesiLozinkaKelner : Form
    {
        Kelner k;
        public VnesiLozinkaKelner(Kelner kelner)
        {
            k = kelner;
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.ForeColor = SystemColors.InfoText;
            tbPassword.PasswordChar = '*';
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals(k.Password))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Внесената лозинка не се совпаѓа!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }


    }
}
