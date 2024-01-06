using Draft.Components;
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
using static Draft.Components.Widget;

namespace Draft
{
    public partial class FormMain : Form
    {
        Connection conn = new Connection();
        SqlConnection conn2 = new SqlConnection();
        public static double TotalOrder {  get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        public void AddItem(string name, double cost, categories category, string icon, int menuID)
        {
            //flowLayoutPanel2.Controls.Add(new Widget()
            //{
            //    Product = name,
            //    Cost = cost,
            //    Category = category,
            //    Picture = Image.FromFile("icons/" + icon),
            //    Tag = category
            //}
            //);
          

            var w = new Widget()
            {
                Product = name,
                Cost = cost,
                Category = category,
                Picture = Image.FromFile("icons/" + icon),
                Tag = category,
                MenuID = menuID
            };
            flowLayoutPanel2.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                int qty = wdg.Qty;

                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lbl_product.Text)
                    {
                       // qty = int.Parse(item.Cells[1].Value.ToString()) + 1;
          
                        double currentPrice = double.Parse(wdg.lbl_cost.Text.ToString().Replace("₱", ""));
                       
                        double newPrice = currentPrice * qty;

                        item.Cells[1].Value = qty;
                        item.Cells[2].Value = $"₱{newPrice}.00";
                        item.Cells[3].Value = menuID;

                        if (qty == 0)
                        {
                            grid.Rows.Remove(item); // Remove the row if qty is 0
                        }
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.lbl_product.Text, qty, wdg.lbl_cost.Text, menuID });
            };

        }

        // Asynchronous method to get menu_price from the database
    
        public void CalculateTotal()
        {
            double tot = 0;
            foreach(DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("₱", ""));
            }
            TotalOrder = tot;
            lbl_total.Text = $"₱{tot}.00";
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {

            //if(Enum.TryParse("Lunch",true, out categories categoryFormatted)){
            //      AddItem("Adobo", 90.00, categoryFormatted, "adobo.jpg");
            //      }
            //      AddItem("Bicol Express", 90.00, categories.Lunch, "bicol-express.jpg");
            //      AddItem("Bottled Water", 30.00, categories.Drinks, "bottled-water.jpg");
            //      AddItem("Coke", 50.00, categories.Drinks, "coke.jpg");
            conn2 = conn.GetConnection();
            conn2.Open();

                string query = "SELECT * FROM dbo.menu";

                using (SqlCommand command = new SqlCommand(query, conn2))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract data from the reader
                           // int menuId = reader.GetInt32(reader.GetOrdinal("menu_id"));
                            string menuName = reader.GetString(reader.GetOrdinal("menu_name"));
                            double menuPrice = (double)reader.GetDecimal(reader.GetOrdinal("menu_price"));
                            string menuCategoryStr = reader.GetString(reader.GetOrdinal("menu_category"));
                            string menuPicture = reader.GetString(reader.GetOrdinal("menu_picture"));
                            int menuID = (int)reader.GetInt32(reader.GetOrdinal("menuID"));

                            // Parse the category string to enum
                            if (Enum.TryParse(menuCategoryStr, true, out categories categoryFormatted))
                            {
                                // Call your method here with the extracted data
                                AddItem(menuName, menuPrice, categoryFormatted, menuPicture, menuID);
                            }
                        }
                    }
                }
            

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            CalculateTotal();
            grid.Refresh();
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotal();
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotal();
        }

        private void SubmitButton_click(object sender, EventArgs e)
        {
            //MessageBox.Show(
            //String.Join("\n", CustomerModel.StudentID, CustomerModel.Name, CustomerModel.Phone));
            conn2 = conn.GetConnection();
            conn2.Open();

            // Insert query with parameters
            string query = "INSERT INTO orders (userID, order_date, total_amount) VALUES (@userID, @order_date, @total_amount); SELECT SCOPE_IDENTITY()";

            using (SqlCommand command = new SqlCommand(query, conn2))
            {
                command.Parameters.AddWithValue("@userID", CustomerModel.userID);
                command.Parameters.AddWithValue("@order_date", DateTime.Now);
                command.Parameters.AddWithValue("@total_amount", TotalOrder);

                int orderID = Convert.ToInt32(command.ExecuteScalar());

            // Set OrderModel variables
                OrderModel.OrderTotal = TotalOrder;
                OrderModel.OrderID = orderID;

                MessageBox.Show("Order Total:" + OrderModel.OrderTotal + " OrderID" + OrderModel.OrderID);
            }


            foreach (DataGridViewRow items in grid.Rows)
            {
                string StrQuery = "INSERT INTO order_items (orderID, menuItem, quantity, menuID) VALUES (@orderID, @menuItem, @quantity, @menuID)";

                int id = OrderModel.OrderID;
                string cell0 = items.Cells[0].Value.ToString();
                int cell1 = int.Parse(items.Cells[1].Value.ToString());
                int cell2 =int.Parse(items.Cells[3].Value.ToString());

                using (SqlCommand comm = new SqlCommand(StrQuery, conn2))
                {
                    comm.Parameters.AddWithValue("@orderID", id);
                    comm.Parameters.AddWithValue("@menuItem", cell0);
                    comm.Parameters.AddWithValue("@quantity", cell1);
                    comm.Parameters.AddWithValue("@menuID", cell2);
                    comm.ExecuteNonQuery();
                }
            }


                OrderSummary orderSummary = new OrderSummary();
            orderSummary.Show();
            this.Hide();

        }

        private void pnl_logout_Click(object sender, EventArgs e)
        {
            // Display confirmation message
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Clear CustomerModel properties
                CustomerModel.Name = null;
                CustomerModel.userID = 0;
                CustomerModel.StudentID = null;
                CustomerModel.Phone = null;

                // Navigate back to Login form
                Login loginForm = new Login();
                this.Hide();
                loginForm.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbl_uName.Text = CustomerModel.Name;
        }
    }
}
