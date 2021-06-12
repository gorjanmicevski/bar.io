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
    public partial class NajavaSanker : Form
    {
        public Sanker sanker;
        public NajavaSanker()
        {
            InitializeComponent();
        }
        private void btnNajaviSe_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                if (Korisnici.checkSanker(tbUsername.Text, tbPassword.Text))
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
        private void tbPassword_Validating(object sender,CancelEventArgs e)
        {
            if (tbUsername.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbUsername, "Корисничкото име е задолжително!");
                e.Cancel = true;
            }
            else
            {
                if (!Korisnici.checkUsernameSanker(tbUsername.Text))
                {
                    errorProvider1.SetError(tbUsername, "Внесовте грешно корисничко име!");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(tbUsername, null);
                    e.Cancel = false;
                }


            }
        }
        private void NajavaSanker_Validating(object sender, CancelEventArgs e)
        {
            
            if (tbUsername.Text == "")
            {
                errorProvider1.SetError(tbUsername, "Корисничкото име е задолжително!");
                e.Cancel = true;
            }
            if (!Korisnici.checkUsernameSanker(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Внесовте грешно корисничко име!");
                e.Cancel = true;
            }
            if (tbPassword.Text == "")
            {
                errorProvider1.SetError(tbPassword, "Лозинката е задолжителна!");
                e.Cancel = true;
            }
            if (!Korisnici.checkPasswordSanker(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Внесовте грешна лозинка!");
                e.Cancel = true;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            sanker = null;
        }

        private void btnNajaviSe_Click_1(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbUsername_Click_1(object sender, EventArgs e)
        {
            tbUsername.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_Click_1(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (Korisnici.checkUsernameSanker(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, null);
                e.Cancel = false;
            }
            else
            {

                errorProvider1.SetError(tbUsername, "Невалидна лозинка!");
                //e.Cancel = true;
            }
        }

        private void tbPassword_Validating_1(object sender, CancelEventArgs e)
        {

            if (Korisnici.checkPasswordSanker(tbPassword.Text))
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

        private void btnNajaviSe_Click_2(object sender, EventArgs e)
        {
            if ((tbUsername.Text.Trim().Length == 0 || tbPassword.Text.Trim().Length == 0) || (tbUsername.Text.Equals("Внесете корисничко име") || (tbPassword.Text.Equals("Внесете лозиинка"))))
            {
                MessageBox.Show("Не Ви е целосно пополнета пријавата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!Korisnici.checkUsernameSanker(tbUsername.Text) || !Korisnici.checkPasswordSanker(tbPassword.Text))
                {
                    MessageBox.Show("Невалидна најава!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sanker = new Sanker(tbUsername.Text, tbPassword.Text);
                    DialogResult = DialogResult.OK;


                }
            }
        }
    }
}
