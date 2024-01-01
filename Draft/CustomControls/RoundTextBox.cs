using System.Windows.Forms;
using System.Drawing;
using System;

namespace Draft.CustomControls
{
    public class RoundTextBox : TextBox
    {
        public int nLeftRect { get; set; }
        public int nRightRect { get; set;}
        public int nHeightRect { get; set; }
        public int nWeightRect { get; set;}

        public RoundTextBox()
        {
            nLeftRect = 2;
            nRightRect = 2;
            nHeightRect = 15;
            nWeightRect = 15;
            this.Font = new Font("Segoe UI", 14);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // X-coordinate of upper-left corner or Padding at start
            int nTopRect, // Y-coordinate of upper-left corner or Padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect, // Y-coordinate of lower-right corner or Height of the object
                             // RADIUS, how round do you want it to be?
            int nheightRect, // height of ellipse
            int nweightRect // width of ellipse
        );



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(nLeftRect, nRightRect, this.Width, this.Height, nHeightRect, nWeightRect)); // play with these values till you are happy
        }

     
    }

}