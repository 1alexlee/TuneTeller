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
    public class ButtonTemplate : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.MidnightBlue;
        public ButtonTemplate()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MidnightBlue;
            this.ForeColor = Color.White;

        }
        

        //get the roundpath of the rectanle based on a radius. 
        GraphicsPath GetRoundPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);


            using (GraphicsPath surfacePath = GetRoundPath(rectSurface, borderRadius))
            using (GraphicsPath borderPath = GetRoundPath(rectBorder, borderRadius - 1f))
            using (Pen surfacePen = new Pen(this.Parent.BackColor, 2))
            using (Pen borderPen = new Pen(borderColor, borderRadius))
            {
                borderPen.Alignment = PenAlignment.Inset;

                this.Region = new Region(surfacePath);
                pevent.Graphics.DrawPath(surfacePen, surfacePath);
            }
        }

        

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
