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
            foreach(Kelner k in kelneri)
            {
                foreach(Masa m in k.Tables)
                {

                    lbNarackiZaIsporaka.Items.Add(m.Naracka);
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
                        lbNarackiZaIsporaka.Items.Remove(selected);
                    }
                    //Dve opcii: koga kje se isporaca da se izvadi od lista ili da se stavi aktivna=false i da stoi..
                    //Prva opcija lesna
                    //Vtora opcija ne mi teknuva kako se prai refresh na lista za da se updatenat narackite i da se smeni aktivna vo false


                    //lbNarackiZaIsporaka.Items.Add(selected);
                    //lbNarackiZaIsporaka.Refresh();
                }
            }
        }
    }
}
