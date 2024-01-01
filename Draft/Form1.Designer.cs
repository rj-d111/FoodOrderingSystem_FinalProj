namespace Draft
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customButton4 = new Draft.CustomControls.CustomButton();
            this.customButton3 = new Draft.CustomControls.CustomButton();
            this.customButton2 = new Draft.CustomControls.CustomButton();
            this.customButton1 = new Draft.CustomControls.CustomButton();
            this.txt_phoneno = new Draft.CustomControls.RoundTextBox();
            this.txt_name = new Draft.CustomControls.RoundTextBox();
            this.txt_customerid = new Draft.CustomControls.RoundTextBox();
            this.customDataGridView1 = new Draft.CustomControls.CustomDataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = global::Draft.Properties.Resources.grub_grab;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(216, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 71);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 87);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.customDataGridView1);
            this.panel3.Controls.Add(this.customButton4);
            this.panel3.Controls.Add(this.customButton3);
            this.panel3.Controls.Add(this.customButton2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.customButton1);
            this.panel3.Controls.Add(this.txt_phoneno);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.txt_customerid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 442);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(44, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID";
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.Maroon;
            this.customButton4.BackgroundColor = System.Drawing.Color.Empty;
            this.customButton4.BorderColor = System.Drawing.Color.Transparent;
            this.customButton4.BorderRadius = 10;
            this.customButton4.borderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(366, 206);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(100, 40);
            this.customButton4.TabIndex = 9;
            this.customButton4.Text = "Search";
            this.customButton4.TextColor = System.Drawing.Color.Empty;
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.Maroon;
            this.customButton3.BackgroundColor = System.Drawing.Color.Empty;
            this.customButton3.BorderColor = System.Drawing.Color.Transparent;
            this.customButton3.BorderRadius = 10;
            this.customButton3.borderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(260, 206);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(100, 40);
            this.customButton3.TabIndex = 8;
            this.customButton3.Text = "Delete";
            this.customButton3.TextColor = System.Drawing.Color.Empty;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Maroon;
            this.customButton2.BackgroundColor = System.Drawing.Color.Empty;
            this.customButton2.BorderColor = System.Drawing.Color.Transparent;
            this.customButton2.BorderRadius = 10;
            this.customButton2.borderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(154, 206);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(100, 40);
            this.customButton2.TabIndex = 7;
            this.customButton2.Text = "Update";
            this.customButton2.TextColor = System.Drawing.Color.Empty;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Maroon;
            this.customButton1.BackgroundColor = System.Drawing.Color.Empty;
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 10;
            this.customButton1.borderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(48, 206);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(100, 40);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "Insert";
            this.customButton1.TextColor = System.Drawing.Color.Empty;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_phoneno.Location = new System.Drawing.Point(169, 144);
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.nHeightRect = 15;
            this.txt_phoneno.nLeftRect = 2;
            this.txt_phoneno.nRightRect = 2;
            this.txt_phoneno.nWeightRect = 15;
            this.txt_phoneno.Size = new System.Drawing.Size(310, 32);
            this.txt_phoneno.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_name.Location = new System.Drawing.Point(169, 94);
            this.txt_name.Name = "txt_name";
            this.txt_name.nHeightRect = 15;
            this.txt_name.nLeftRect = 2;
            this.txt_name.nRightRect = 2;
            this.txt_name.nWeightRect = 15;
            this.txt_name.Size = new System.Drawing.Size(310, 32);
            this.txt_name.TabIndex = 1;
            // 
            // txt_customerid
            // 
            this.txt_customerid.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_customerid.Location = new System.Drawing.Point(169, 38);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.nHeightRect = 15;
            this.txt_customerid.nLeftRect = 2;
            this.txt_customerid.nRightRect = 2;
            this.txt_customerid.nWeightRect = 15;
            this.txt_customerid.Size = new System.Drawing.Size(310, 32);
            this.txt_customerid.TabIndex = 0;
            // 
            // customDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.customDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.customDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.customDataGridView1.Location = new System.Drawing.Point(48, 263);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.Size = new System.Drawing.Size(431, 150);
            this.customDataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 529);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RoundTextBox txt_customerid;
        private CustomControls.RoundTextBox txt_phoneno;
        private CustomControls.RoundTextBox txt_name;
        private CustomControls.CustomButton customButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomButton customButton3;
        private CustomControls.CustomButton customButton4;
        private CustomControls.CustomDataGridView customDataGridView1;
    }
}

