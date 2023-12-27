namespace FoodOrderingSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customButton1 = new FoodOrderingSystem.CustomButton();
            this.roundedPanel2 = new FoodOrderingSystem.RoundedPanel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.roundedPanel1 = new FoodOrderingSystem.RoundedPanel();
            this.txt_stud = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign in to continue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "STUDENT NO.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.roundedPanel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 362);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(186)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(208, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "SIGN UP";
            this.label6.Click += new System.EventHandler(this.Sign_up);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "DON\'T HAVE AN ACCOUNT?";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(186)))), ((int)(((byte)(43)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.Empty;
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 15;
            this.customButton1.borderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(25, 265);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(267, 43);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "LOGIN";
            this.customButton1.TextColor = System.Drawing.Color.Empty;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.txt_pass);
            this.roundedPanel2.CornerOutline = System.Drawing.Color.Transparent;
            this.roundedPanel2.CornerRadius = 30;
            this.roundedPanel2.CornerThickness = 0;
            this.roundedPanel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.roundedPanel2.Location = new System.Drawing.Point(25, 202);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(267, 39);
            this.roundedPanel2.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_pass.Location = new System.Drawing.Point(18, 10);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '•';
            this.txt_pass.Size = new System.Drawing.Size(235, 22);
            this.txt_pass.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.txt_stud);
            this.roundedPanel1.CornerOutline = System.Drawing.Color.Transparent;
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.CornerThickness = 0;
            this.roundedPanel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.roundedPanel1.Location = new System.Drawing.Point(25, 120);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(267, 40);
            this.roundedPanel1.TabIndex = 0;
            // 
            // txt_stud
            // 
            this.txt_stud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stud.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_stud.Location = new System.Drawing.Point(18, 10);
            this.txt_stud.Name = "txt_stud";
            this.txt_stud.Size = new System.Drawing.Size(235, 22);
            this.txt_stud.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FoodOrderingSystem.Properties.Resources.Cafeteria_021;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 279);
            this.panel2.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::FoodOrderingSystem.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(294, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(18, 18);
            this.btn_close.TabIndex = 0;
            this.btn_close.Click += new System.EventHandler(this.panel3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.TextBox txt_stud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label4;
        private CustomButton customButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel btn_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

