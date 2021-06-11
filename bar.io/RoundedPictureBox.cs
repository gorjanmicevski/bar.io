using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace bar.io
{
    public class RoundedPictureBox : PictureBox
    {
       protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, Width - 1, Height - 1);
                Region rg = new Region(gp);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);

                Region = rg;
            }
        }
    }
}
