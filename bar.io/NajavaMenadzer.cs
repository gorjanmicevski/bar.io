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
        public Menadzer m;
        public NajavaMenadzer()
        {
            InitializeComponent();
            
        }

        private void btnNajaviSe_Click(object sender, EventArgs e)
        {
            
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
        }
        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }
        /*
        private void NajavaMenadzer_Validating(object sender, CancelEventArgs e)
        {
            if(tbUsername.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbUsername, "Корисничкото име е задолжително!");
                e.Cancel = true;
            }
            if (!Korisnici.checkUsernameMenadzer(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Внесовте грешно корисничко име!");
                e.Cancel = true;
            }
            if(tbPassword.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbPassword, "Лозинката е задолжителна!");
                e.Cancel = true;
            }
            if (!Korisnici.checkPasswordMenadzer(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Внесовте грешна лозинка!");
                e.Cancel = true;
            }
            errorProvider1.SetError(tbPassword, null);
            e.Cancel = false;
        }
        */
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbUsername, null);
            errorProvider1.SetError(tbPassword, null);
            DialogResult = DialogResult.Cancel;
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (Korisnici.checkUsernameMenadzer(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbUsername, "Невалидно корисничко име!");
                //e.Cancel = true;
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (Korisnici.checkPasswordMenadzer(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, null);
                e.Cancel = false;
            }
            else
            {
                
                errorProvider1.SetError(tbPassword, "Невалидна лозинка!");
                //e.Cancel = true;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            tbUsername.ForeColor = SystemColors.InfoText;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.ForeColor = SystemColors.InfoText;
            tbPassword.PasswordChar = '*';
        }

        private void btnNajaviSe_Click_1(object sender, EventArgs e)
        {
            if ((tbUsername.Text.Trim().Length != 0 && tbPassword.Text.Trim().Length != 0) && (!tbUsername.Text.Equals("Внесете корисничко име") && (!tbPassword.Text.Equals("Внесете лозиинка"))))
            {
                if (Korisnici.checkMenadzer(tbUsername.Text, tbPassword.Text))
                {
                    m = Korisnici.getMenadzer(tbUsername.Text, tbPassword.Text);
                    DialogResult = DialogResult.OK;
                }
                // else
                // {
                //     DialogResult = DialogResult.OK;

                //}
            }
            else
            {
                m = null;
                MessageBox.Show("Не Ви е целосно пополнета пријавата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
