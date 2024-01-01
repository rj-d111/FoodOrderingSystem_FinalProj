using Draft.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormMain()
        {
            InitializeComponent();
        }

        public void AddItem(string name, double cost, categories category, string icon)
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
                Tag = category
            };
            flowLayoutPanel2.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach(DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lbl_product.Text)
                    {
                        int qty = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[1].Value = qty;
                        double currentPrice = double.Parse(item.Cells[2].Value.ToString().Replace("₱", ""));
                        double priceEach = currentPrice / (qty-1);
                        double newPrice = priceEach * qty;
                        item.Cells[2].Value = $"₱{newPrice}.00";
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.lbl_product.Text, 1, wdg.lbl_cost.Text });
            };

        }

        private void CalculateTotal()
        {
            double tot = 0;
            foreach(DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("₱", ""));
            }
            lbl_total.Text = $"₱{tot}.00";
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            
            

            AddItem("Adobo", 90.00, categories.Lunch, "adobo.jpg");
            AddItem("Bicol Express", 90.00, categories.Lunch, "bicol-express.jpg");
            AddItem("Bottled Water", 30.00, categories.Drinks, "bottled-water.jpg");
            AddItem("Coke", 50.00, categories.Drinks, "coke.jpg");


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
    }
}
