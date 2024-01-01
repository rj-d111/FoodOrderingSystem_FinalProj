using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft.CustomControls
{
    public class PaddedTextBox : TextBox
    {
        public int Padding { get; set; } // Adjust Padding as needed

        public PaddedTextBox() { 
        
            Padding = 5;
        }  

        protected override void OnPaint(PaintEventArgs e)
        {
            // Adjust drawing rectangle to include Padding
            Rectangle rect = new Rectangle(
                this.ClientRectangle.X + Padding,
                this.ClientRectangle.Y + Padding,
                this.ClientRectangle.Width - 2 * Padding,
                this.ClientRectangle.Height - 2 * Padding);
            base.OnPaint(new PaintEventArgs(e.Graphics, rect));
        }
    }
}
