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
    public partial class NajavaMenadzer : Form
    {
        public NajavaMenadzer()
        {
            InitializeComponent();
        }

        private void btnNajaviSe_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                if(Korisnici.checkMenadzer(tbUsername.Text, tbPassword.Text))
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
        }
        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }

        private void NajavaMenadzer_Validating(object sender, CancelEventArgs e)
        {
            if(tbUsername.Text == "")
            {
                errorProvider1.SetError(tbUsername, "Корисничкото име е задолжително!");
                e.Cancel = true;
            }
            if (!Korisnici.checkUsernameMenadzer(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Внесовте грешно корисничко име!");
                e.Cancel = true;
            }
            if(tbPassword.Text == "")
            {
                errorProvider1.SetError(tbPassword, "Лозинката е задолжителна!");
                e.Cancel = true;
            }
            if (!Korisnici.checkPasswordMenadzer(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Внесовте грешна лозинка!");
                e.Cancel = true;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
