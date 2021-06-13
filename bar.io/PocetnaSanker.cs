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
    public partial class PocetnaSanker : Form
    {
        List<Kelner> kelneri;
        public PocetnaSanker()
        {
            InitializeComponent();
            kelneri = Pocetna.kelneri;
            
        }

      

        private void PocetnaSanker_Load(object sender, EventArgs e)
        {

            updateList();
            
        }
        private void updateList()
        {
            lbNarackiZaIsporaka.Items.Clear();
            lbIsporacani.Items.Clear();
            foreach (Kelner k in kelneri)
            {
                foreach (Masa m in k.Tables)
                {
                    if (m.Naracka.poracaniArtikli.Count != 0)
                    {
                        if (m.Naracka.aktivna == false)
                            lbIsporacani.Items.Add(m.Naracka);
                        else
                            lbNarackiZaIsporaka.Items.Add(m.Naracka);
                    }
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (lbNarackiZaIsporaka.SelectedIndex != -1)
            {
                Naracka selected = (Naracka)lbNarackiZaIsporaka.SelectedItem;
                Isporaka form = new Isporaka();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (lbNarackiZaIsporaka.SelectedItem != null)
                    {
                        selected.aktivna = false;
                        updateList();
                    }
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lbNarackiZaIsporaka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
