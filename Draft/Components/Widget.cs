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
    }
}
