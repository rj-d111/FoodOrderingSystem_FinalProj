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
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgImage);
            this.panel1.Controls.Add(this.lbl_cost);
            this.panel1.Controls.Add(this.lbl_product);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 101);
            this.panel1.TabIndex = 0;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cost.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_cost.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_cost.Location = new System.Drawing.Point(19, 59);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(57, 25);
            this.lbl_cost.TabIndex = 1;
            this.lbl_cost.Text = "90.00";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_product.Location = new System.Drawing.Point(20, 22);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(43, 15);
            this.lbl_product.TabIndex = 0;
            this.lbl_product.Text = "Adobo";
            // 
            // imgImage
            // 
            this.imgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgImage.Image = global::Draft.Properties.Resources.adobo;
            this.imgImage.Location = new System.Drawing.Point(110, 22);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(84, 62);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImage.TabIndex = 2;
            this.imgImage.TabStop = false;
            this.imgImage.Click += new System.EventHandler(this.Picture_Click);
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
        public System.Windows.Forms.Label lbl_product;
        public System.Windows.Forms.PictureBox imgImage;
    }
}
