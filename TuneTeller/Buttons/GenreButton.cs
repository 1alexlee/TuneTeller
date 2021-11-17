using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TuneTeller
{
    public class GenreButton : Button
    {

        GenreButton()
        {
            this.BackColor = Color.RoyalBlue;
        }


        //graphics path for rounded corners

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            //float value difference 1.0
            float m = 1.75f;
            
            float r2 = radius / 2f;

            GraphicsPath GraphPath = new GraphicsPath();
            //path drawn for corners of rect
            GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m,
                           Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
            GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

            GraphPath.CloseFigure();
            return GraphPath;


        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            int borderRadius = 40;
            float borderThickness = 1.75f;

            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, borderRadius);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.Black, borderThickness))
            {
                pen.Alignment = PenAlignment.Outset;
                //changed above from .inset to .outset
                pevent.Graphics.DrawPath(pen, GraphPath);
            }
        }
        //change button and mouse color on mouseover
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = Color.SlateBlue;

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.RoyalBlue;
        }




    }
}
