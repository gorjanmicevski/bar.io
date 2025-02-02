﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            myArtikal = new Artikal(textBox1.Text.ToString(),Int32.Parse(textBox2.Text.ToString()));
            kolicina = Int32.Parse(textBox3.Text.ToString());
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "Ова поле е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                e.Cancel = false;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {

                errorProvider1.SetError(textBox2, "Ова поле е задолжително!");
                e.Cancel = true;
            }
            else
            {
                int pom1;
                if (!Int32.TryParse(textBox2.Text, out pom1))
                {
                    errorProvider1.SetError(textBox2, "Не валиден влез!");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(textBox2,null);
                    e.Cancel = false;
                }
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {

                errorProvider1.SetError(textBox3, "Ова поле е задолжително!");
                e.Cancel = true;
            }
            else
            {
                int pom1;
                if (!Int32.TryParse(textBox3.Text, out pom1))
                {
                    errorProvider1.SetError(textBox3, "Не валиден влез!");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(textBox3, null);
                    e.Cancel = false;
                }
            }
        }
    }
}
