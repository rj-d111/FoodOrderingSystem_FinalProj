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
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OrderReceipt orderReceipt = new OrderReceipt();
            orderReceipt.Show();
            this.Hide();
        }

        private void Success_Load(object sender, EventArgs e)
        {
            lbl_hey.Text = "Hey, " + CustomerModel.Name;
            lbl_uName.Text = CustomerModel.Name;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void pnl_logout_Click(object sender, EventArgs e)
        {
            Logout.ShowLogoutConfirmation(this);
        }
    }
}
