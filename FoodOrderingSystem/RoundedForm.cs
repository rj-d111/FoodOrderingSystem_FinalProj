using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystem
{
    public class RoundedForm : Form
    {
        private int cornerRadius { get; set; } // Adjust as needed

        public RoundedForm()
        {
            this.cornerRadius = 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = CreateRoundedRectangle(ClientRectangle, cornerRadius);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Fill background (if desired)
            if (BackColor != Color.Transparent)
            {
                e.Graphics.FillPath(new SolidBrush(BackColor), path);
            }

            // Draw border (if desired)
            if (FormBorderStyle != FormBorderStyle.None)
            {
                e.Graphics.DrawPath(Pens.Black, path); // Adjust border color/thickness as needed
            }

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

        // Enable rounded corners in non-client area (title bar, etc.)
        [DllImport("dwmapi.dll")]
        private

    static

    extern

    int

    DwmSetWindowAttribute(IntPtr hwnd, int attr, ref

    int attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Apply rounded corners to non-client area
            const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
            int DWMWCP_ROUND = 2;

            DwmSetWindowAttribute(Handle, DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_ROUND, 4);
        }
    }
}