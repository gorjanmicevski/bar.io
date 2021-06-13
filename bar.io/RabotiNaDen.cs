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
    public partial class RabotiNaDen : Form
    {
        string date;
        DateTime data;
        private StringReader myReader;

        public RabotiNaDen(string str,DateTime data)
        {
            date = str;
            this.data = data;
            InitializeComponent();
        }

        private void RabotiNaDen_Load(object sender, EventArgs e)
        {
            if (Lokal.Reservations != null)
            {
                if (Lokal.Reservations.ContainsKey(date))
                {
                    foreach (Rezervacija r in Lokal.Reservations[date])
                    {
                        lbRezervacii.Items.Add(r);
                    }
                }
                else
                {
                    Lokal.Reservations.Add(date, new List<Rezervacija>());
                    Lokal.AvailableTables.Add(date, new List<Masa>());
                    List<Masa> masi = new List<Masa>(5) { new Masa(1, 5), new Masa(2, 5), new Masa(3, 5), new Masa(4, 5), new Masa(5, 5) };
                    Lokal.AvailableTables[date] = masi;

                }
            }
        }

        private void btnDodadiRezervacija_Click(object sender, EventArgs e)
        {
            DodadiRezervacija forma = new DodadiRezervacija(date);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                Rezervacija r = forma.myRezervacija;
                Masa m = forma.myMasa;
                Lokal.Reservations[date].Add(r);
                Lokal.AvailableTables[date].Remove(m);
                lbRezervacii.Items.Add(r);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbRezervacii.SelectedItem != null)
            {
                Rezervacija r = (Rezervacija)lbRezervacii.SelectedItem;
                Lokal.Reservations[date].Remove(r);
                lbRezervacii.Items.Remove(r);
            }
            else
            {
                MessageBox.Show("Немате селектирано резервација за бришење!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
                printDialog1.Document = printDocument1;
                string strText = "";
                 foreach (object x in lbRezervacii.Items)
                    {
                         strText = strText + x.ToString() + "\n";
                    }
            
                     myReader = new StringReader(strText);
                 if (printDialog1.ShowDialog() == DialogResult.OK)
                     {
                         this.printDocument1.Print();
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
                 Font printFont = this.lbRezervacii.Font;
                 SolidBrush myBrush = new SolidBrush(Color.Black);
            
      linesPerPage =ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            
      while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
                    {
                        
          yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));
                
                         

                         ev.Graphics.DrawString(line, printFont,
                                                myBrush, leftMargin,
                                                yPosition, new StringFormat());
                         count++;
                     }
            
     
                 if (line != null)
                         ev.HasMorePages = true;
                 else
                         ev.HasMorePages = false;
            
            myBrush.Dispose();
        }
    }
}
