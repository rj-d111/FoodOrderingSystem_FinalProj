﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevOne.Security.Cryptography.BCrypt;

namespace FoodOrderingSystem
{
    public partial class Login : RoundedForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Create property for user
        public static string User {  get; set; }

             private void customButton1_Click(object sender, EventArgs e)
            {
                //Get the email and the password of the user
                string stud = txt_stud.Text;
                string pass = passwordTextBox.Text;

                Connection con = new Connection();
                SqlConnection sqlconn = new SqlConnection();
            sqlconn = con.GetConnection();

            try
            {
                string query = "SELECT * FROM customer WHERE username = @stud AND password = @pass";

                // Create a SqlCommand object to execute the query
                using (SqlCommand command = new SqlCommand(query, sqlconn))
                {
                    // Add parameters to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@stud", stud);
                    command.Parameters.AddWithValue("@pass", pass);

                    // Open the connection
                    sqlconn.Open();


                    // Assign the username to the public string User
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);

                    // Execute the query and get the username
                    //string username = (string)command.ExecuteScalar();

                    if (dt.Rows.Count > 0)
                    {
                        // Credentials match
                        MessageBox.Show("Login successful!");

                        //Get the first name in the index 3
                        User = dt.Rows[0]["fname"].ToString();
                        // Proceed to the next step (e.g., navigate to another form)
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        // Credentials don't match
                        MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
       

        private void Sign_up(object sender, EventArgs e)
        {
            Create_Account create_Account = new Create_Account();
            create_Account.Show();
            this.Hide();
        }
    }
}
