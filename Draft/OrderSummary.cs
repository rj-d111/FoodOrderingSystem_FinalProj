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
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Draft
{
    public partial class OrderSummary : Form
    {
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
            OrderModel.TenderAmount = double.Parse(txt_amount.Text);
            double change = OrderModel.TenderAmount - OrderModel.OrderTotal;

            if (change < 0)
            {
                MessageBox.Show("Transaction Declined. You have insufficient Balance");
            }
            else
            {
                MessageBox.Show("Successfully paid. Your change is ₱" + change + ".00");
                InsertInPaymentTable();
                Success success = new Success();
                success.Show();
                this.Hide();
            }
        }

        private void InsertInPaymentTable()
        {
            string sql = @"INSERT INTO payments (orderID, payment_date, amount_paid, payment_method)
                       VALUES (@orderID, @payment_date, @amount_paid, @payment_method)";

            //Insert the date today
            OrderModel.PaymentDate = DateTime.Now;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Set parameters for security and to avoid SQL injection
                command.Parameters.Add("@orderID", SqlDbType.Int).Value = OrderModel.OrderID;
                command.Parameters.Add("@payment_date", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@amount_paid", SqlDbType.Decimal).Value = OrderModel.TenderAmount;
                command.Parameters.Add("@payment_method", SqlDbType.VarChar).Value = GetSelectedPaymentMethod();

                // Open the connection and execute the command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment inserted successfully!");
                }
                else
                {
                    MessageBox.Show("Payment insertion failed.");
                }
            }
        }

        private string GetSelectedPaymentMethod()
        {
            string paymentMethod = "";
            if(radioButton1.Checked)
                paymentMethod = radioButton1.Text;
            if(radioButton2.Checked)
                paymentMethod = radioButton2.Text;

            return paymentMethod;
        }
    }
}
