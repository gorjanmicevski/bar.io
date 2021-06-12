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

        private void btnDodadi_Click_1(object sender, EventArgs e)
        {
            if (tbID.Text.Length != 0 && tbID.Text != "" && textBox1.Text.Length != 0 && textBox1.Text != "")
            {
                int pom1;
                int pom2;
                if (!Int32.TryParse(tbID.Text, out pom1))
                {
                    MessageBox.Show("Не валиден влез во првото поле!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!Int32.TryParse(textBox1.Text, out pom1))
                {
                    MessageBox.Show("Не валиден влез во второто поле!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    myMasa = new Masa(int.Parse(tbID.Text), int.Parse(textBox1.Text));
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Не ви е целосно пополнета пријавата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnOtkazi_Click_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbID, null);
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
        public void tableToEdit(Masa m)
        {
            tbID.Text = m.Id.ToString();
            textBox1.Text = m.AvailableSeats.ToString();
        }

        private void tbID_Validating(object sender, CancelEventArgs e)
        {
            if (tbID.Text.Length == 0)
            {
                errorProvider1.SetError(tbID, "Ова поле е задолжително!");
                //e.Cancel = true;
            }
            else
            {
                int pom1;
                if (!Int32.TryParse(tbID.Text, out pom1))
                {
                    errorProvider1.SetError(tbID, "Не валиден влез!");
                    //e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(tbID, null);
                    //e.Cancel = false;
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "Ова поле е задолжително!");
                //e.Cancel = true;
            }
            else
            {
                int pom1;
                if (!Int32.TryParse(textBox1.Text, out pom1))
                {
                    errorProvider1.SetError(textBox1, "Не валиден влез!");
                    //e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(textBox1, null);
                    //e.Cancel = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
