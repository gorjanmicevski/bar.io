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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Не ви е целосно пополнета пријавата!","Грешка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                m = new Menadzer(textBox1.Text, textBox2.Text, 0, 0);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
