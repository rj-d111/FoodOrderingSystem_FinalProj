using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft.Components
{
    public partial class Widget : UserControl
    {
        public int MenuID { get; set; } // Add a property to store the menuID or unique identifier
        public int Qty { get; set; }
        public categories _category;

        public event EventHandler OnSelect = null;

        public Widget()
        {
            InitializeComponent();
        }

        public enum categories { Breakfast, Lunch, Snacks, Drinks, Desserts, Others };
        public categories Category { get=> _category; set=> _category = value; }
        public string Product { get => lbl_product.Text; set => lbl_product.Text = value; }
        public double Cost
        {
            get => double.Parse(lbl_cost.Text, NumberStyles.Currency);
            set => lbl_cost.Text = $"₱{value}.00";
        }
        public Image Picture { get => imgImage.Image; set => imgImage.Image = value; }

        private void Picture_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_plus_Click(object sender, EventArgs e)
        {
            Qty++;
            OnSelect?.Invoke(this, e);
            lbl_qty.Text = Qty.ToString();
        }

        private void lbl_minus_Click(object sender, EventArgs e)
        {
            if(Qty > 0)
            {
            Qty--;
            OnSelect?.Invoke(this, e);
            lbl_qty.Text = Qty.ToString();
            }
        }
    }
}
