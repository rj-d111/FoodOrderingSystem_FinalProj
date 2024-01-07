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
    public partial class OrderReceipt : Form
    {
        Connection conn = new Connection();
        SqlConnection connection = new SqlConnection();
        public OrderReceipt()
        {
            InitializeComponent();
        }

        private void OrderReceipt_Load(object sender, EventArgs e)
        {
            lbl_uName.Text = CustomerModel.Name;
            lbl_change.Text = "₱"+(OrderModel.TenderAmount - OrderModel.OrderTotal)+ ".00";
            lbl_tender.Text = "₱" +OrderModel.TenderAmount+".00";
            lbl_grandTotal.Text = "₱" + OrderModel.OrderTotal + ".00";
            lbl_orderID.Text = OrderModel.OrderID.ToString();
            // Format the payment date and time as desired
            string formattedDateTime = OrderModel.PaymentDate.ToString("MM/dd/yyyy hh:mm tt");  // Example format: 01/23/2024 05:31 PM
            // Assign the formatted value to the label's Text property
            lbl_date.Text = formattedDateTime;

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

        private void label1_Click(object sender, EventArgs e)
        {
            Success success = new Success();
            success.Show();
            this.Hide();
        }
    }
}
