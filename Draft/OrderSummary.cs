using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft
{
    public partial class OrderSummary : Form
    {
        public static double TextAmount { get; set; }
        Connection conn = new Connection();
        SqlConnection connection = new SqlConnection();
        public OrderSummary()
        {
            InitializeComponent();
        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            lbl_uName.Text = CustomerModel.Name;
            lbl_subtotal.Text = "₱" + OrderModel.OrderTotal + ".00";
            lbl_grandTotal.Text = "₱" + OrderModel.OrderTotal + ".00";

            //Data Grid View
            connection = conn.GetConnection();
            connection.Open();

            // Prepare the query with the specified orderID
            string query = "SELECT * FROM order_items WHERE orderID = @orderID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@orderID", OrderModel.OrderID);

                // Open the connection and execute the query
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Iterate through the rows and add data to the DataGridView
                    while (reader.Read())
                    {
                        // Create a row in the DataGridView
                        grid.Rows.Add(new object[] { reader["menuID"], reader["menuItem"], reader["quantity"], reader["menuPrice"] });
                    }
                }

                }
            }

        private void pnl_logout_Click(object sender, EventArgs e)
        {
            Logout.ShowLogoutConfirmation(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;  // Prevent non-numeric characters
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && txt_amount.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            TextAmount = double.Parse(txt_amount.Text);
            double change = TextAmount - OrderModel.OrderTotal;

            if (change < 0)
            {
                MessageBox.Show("Transaction Declined. You have insufficient Balance");
            }
            else
            {
                MessageBox.Show("Successfully paid. Your change is ₱" + change + ".00");
                Success success = new Success();
                success.Show();
                this.Hide();
            }
        }
    }
}
