using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystem
{
    public class RoundedPanel : Panel
    {

        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        public int CornerRadius { get; set; }

        public Color CornerOutline {  get; set; }

        public int CornerThickness { get; set; }

        public RoundedPanel()
        {
            this.BackColor = Color.White;
            this.CornerRadius = 30;
            this.CornerOutline = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = CreateRoundedRectangle(ClientRectangle, CornerRadius);
            e.Graphics.DrawPath(new Pen(CornerOutline), path);
            e.Graphics.FillPath(new SolidBrush(BackColor), path); // Adjust background color as needed
            Region = new Region(path);

            base.OnPaint(e);
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
