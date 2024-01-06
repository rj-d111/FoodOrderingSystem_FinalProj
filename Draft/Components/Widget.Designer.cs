namespace Draft.Components
{
    partial class Widget
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_product = new Draft.CustomControls.TransparentRichTextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_plus = new System.Windows.Forms.Label();
            this.lbl_minus = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_product);
            this.panel1.Controls.Add(this.lbl_qty);
            this.panel1.Controls.Add(this.lbl_plus);
            this.panel1.Controls.Add(this.lbl_minus);
            this.panel1.Controls.Add(this.imgImage);
            this.panel1.Controls.Add(this.lbl_cost);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 101);
            this.panel1.TabIndex = 0;
            // 
            // lbl_product
            // 
            this.lbl_product.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_product.Location = new System.Drawing.Point(23, 13);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.ReadOnly = true;
            this.lbl_product.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lbl_product.Size = new System.Drawing.Size(81, 31);
            this.lbl_product.TabIndex = 7;
            this.lbl_product.Text = "Adobo";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.BackColor = System.Drawing.Color.White;
            this.lbl_qty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_qty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_qty.Location = new System.Drawing.Point(39, 68);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(17, 19);
            this.lbl_qty.TabIndex = 5;
            this.lbl_qty.Text = "0";
            this.lbl_qty.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_plus
            // 
            this.lbl_plus.AutoSize = true;
            this.lbl_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_plus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_plus.Location = new System.Drawing.Point(62, 69);
            this.lbl_plus.Name = "lbl_plus";
            this.lbl_plus.Size = new System.Drawing.Size(19, 19);
            this.lbl_plus.TabIndex = 4;
            this.lbl_plus.Text = "+";
            this.lbl_plus.Click += new System.EventHandler(this.lbl_plus_Click);
            // 
            // lbl_minus
            // 
            this.lbl_minus.AutoSize = true;
            this.lbl_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_minus.Location = new System.Drawing.Point(22, 69);
            this.lbl_minus.Name = "lbl_minus";
            this.lbl_minus.Size = new System.Drawing.Size(15, 19);
            this.lbl_minus.TabIndex = 3;
            this.lbl_minus.Text = "-";
            this.lbl_minus.Click += new System.EventHandler(this.lbl_minus_Click);
            // 
            // imgImage
            // 
            this.imgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgImage.Image = global::Draft.Properties.Resources.adobo;
            this.imgImage.Location = new System.Drawing.Point(110, 13);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(84, 62);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImage.TabIndex = 2;
            this.imgImage.TabStop = false;
            this.imgImage.Click += new System.EventHandler(this.Picture_Click);
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cost.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_cost.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_cost.Location = new System.Drawing.Point(18, 42);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(57, 25);
            this.lbl_cost.TabIndex = 1;
            this.lbl_cost.Text = "90.00";
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Widget";
            this.Size = new System.Drawing.Size(216, 101);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_cost;
        public System.Windows.Forms.PictureBox imgImage;
        public System.Windows.Forms.Label lbl_qty;
        public System.Windows.Forms.Label lbl_plus;
        public System.Windows.Forms.Label lbl_minus;
        public CustomControls.TransparentRichTextBox lbl_product;
    }
}
