using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections;

namespace bar.io
{
    public partial class PocetnaKelner : Form
    {
        public Kelner kelner;

        private StringReader myReader;
        public PocetnaKelner(Kelner k)
        {
            kelner = k;
            if (k == null)
            {
                kelner = new Kelner(k.Name);
            }
            InitializeComponent();
        }

        
        private void PocetnaKelner_Load(object sender, EventArgs e)
        {
            lbMasi.Items.Clear();
            foreach (Masa m in kelner.Tables)
            {
                lbMasi.Items.Add(m);
            }
        }

        private void btnDodadiMasa_Click(object sender, EventArgs e)
        {
            DodadiMasa forma = new DodadiMasa();
            if(forma.ShowDialog() == DialogResult.OK)
            {
                Masa m = forma.myMasa;
                bool flag = false;
                foreach(Masa item in kelner.Tables)
                {
                    if (item.Id==m.Id)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    MessageBox.Show("Масате веќе постои!", "Неуспешно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    kelner.Tables.Add(m);
                    DodadiNaracka forma1 = new DodadiNaracka(m,kelner);
                    if (forma1.ShowDialog() == DialogResult.OK)
                    {
                        m.Naracka.poracaniArtikli = forma1.dikshneri;
                        lbMasi.Items.Add(m);
                    }
                    
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnIzbrisiMasa_Click(object sender, EventArgs e)
        {
            if (lbMasi.SelectedItem!=null)
            {
                VnesiLozinkaMenadzer forma = new VnesiLozinkaMenadzer(Korisnici.Menadzeri);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    int index = lbMasi.SelectedIndex;
                    Masa m = (Masa)lbMasi.Items[index];//***
                    lbMasi.Items.RemoveAt(index);
                    kelner.Tables.Remove(m);//****
                   // DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                MessageBox.Show( "Немате селектирано маса!", "грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnEditMasa_Click(object sender, EventArgs e)
        {
            if (lbMasi.SelectedItem != null)
            {
                Masa selektirana = (Masa)lbMasi.SelectedItem;
                DodadiNaracka forma1 = new DodadiNaracka(selektirana,kelner);
                if (forma1.ShowDialog() == DialogResult.OK)
                {

                }
                /* DodadiMasa m = new DodadiMasa();
                 m.tableToEdit((Masa)lbMasi.SelectedItem);
                 if (m.ShowDialog() == DialogResult.OK)
                 {
                     lbMasi.SelectedItem =(Masa) m.myMasa;

                     this.UpdateList();
                 }
                */
            }
            else
            {
                MessageBox.Show("Немате селектирано маса!", "грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void UpdateList()
        {
            lbMasi.Items.Clear();
            foreach(Masa m in kelner.Tables)
            {
                lbMasi.Items.Add(m);
            }
        }

        private void btnSmetka_Click(object sender, EventArgs e)
        {
            string pomstring;
            Masa selektirana = (Masa)lbMasi.SelectedItem;
            if (selektirana != null)
            {
                Naracka n = selektirana.Naracka;

                if (n != null)
                {
                    printDialog1.Document = printDocument1;
                    string strText = "";
                    foreach (Artikal a in n.poracaniArtikli.Keys)
                    {
                        pomstring = String.Format("{0}\t{1}", a.Ime, n.poracaniArtikli[a] * a.Cena);
                        strText = strText + pomstring + "\n";
                    }
                    myReader = new StringReader(strText);
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        this.printDocument1.Print();
                    }
                }
                else
                {
                    MessageBox.Show( "Нема што да се принта!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show( "Немате селектирано маса!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.lbMasi.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            // Work out the number of lines per page, using the MarginBounds.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Iterate over the string using the StringReader, printing each line.
            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                // calculate the next line position based on
                // the height of the font according to the printing device
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));

                // draw the next line in the rich edit control

                ev.Graphics.DrawString(line, printFont, myBrush, leftMargin,yPosition, new StringFormat());
                count++;
            }

            // If there are more lines, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

            myBrush.Dispose();
        }
    }
}
                
