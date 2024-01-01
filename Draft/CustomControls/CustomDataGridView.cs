using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft.CustomControls
{
    class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {

            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Set the header background color to maroon and foreground color to white
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13);

            // Set the body background color to black and text color to gray
            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.Font = new Font("Segoe UI", 11);

            // Add gray stripes to the body
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

        }
    }

}
