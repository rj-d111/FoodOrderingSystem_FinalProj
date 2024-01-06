using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft
{
    public partial class OrderReceipt : Form
    {
        public OrderReceipt()
        {
            InitializeComponent();
        }

        private void OrderReceipt_Load(object sender, EventArgs e)
        {
            lbl_uName.Text = CustomerModel.Name;
            lbl_change.Text = "₱"+OrderModel.OrderTotal+".00";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Success success = new Success();
            success.Show();
            this.Hide();
        }
    }
}
