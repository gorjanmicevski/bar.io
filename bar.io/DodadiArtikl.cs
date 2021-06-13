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
    public partial class DodadiArtikl : Form
    {
        public Artikal myArtikal { set; get; }
        public int kolicina { set; get; }

        public DodadiArtikl()
        {
            InitializeComponent();
        }
        private bool isValid()
        {
            int pom1;
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || !Int32.TryParse(textBox3.Text, out pom1) || !Int32.TryParse(textBox2.Text, out pom1))
            return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                myArtikal = new Artikal(textBox1.Text.ToString(), Int32.Parse(textBox2.Text.ToString()));
                kolicina = Int32.Parse(textBox3.Text.ToString());
                DialogResult = DialogResult.OK;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, null);
            errorProvider1.SetError(textBox2, null);
            errorProvider1.SetError(textBox3, null);
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "Ова поле е задолжително!");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {

                errorProvider1.SetError(textBox2, "Ова поле е задолжително!");
            }
            else
            {
                int pom1;
                if (!Int32.TryParse(textBox2.Text, out pom1))
                {
                    errorProvider1.SetError(textBox2, "Невалиден влез!");
                }
                else
                {
                    errorProvider1.SetError(textBox2,null);
                }
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {

                errorProvider1.SetError(textBox3, "Ова поле е задолжително!");
            }
            else
            {
                int pom1;
                if (!Int32.TryParse(textBox3.Text, out pom1))
                {
                    errorProvider1.SetError(textBox3, "Не валиден влез!");
                }
                else
                {
                    errorProvider1.SetError(textBox3, null);
                }
            }
        }
    }
}
