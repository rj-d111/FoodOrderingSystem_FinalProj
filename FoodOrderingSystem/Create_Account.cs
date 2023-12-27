using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystem
{
    public partial class Create_Account : RoundedForm
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string fname = txt_fname.Text;
            string lname = txt_lname.Text;
            string stud_id = txt_stud.Text;
            string phone = txt_phone.Text;
            string password = txt_pass.Text;
            string password2 = txt_pass2.Text;

            bool isValid = true;
            string errorMessage = "";

            // Validate fname and lname
            if (string.IsNullOrEmpty(fname))
            {
                isValid = false;
                errorMessage += "First name cannot be empty.\n";
            }
            if (string.IsNullOrEmpty(lname))
            {
                isValid = false;
                errorMessage += "Last name cannot be empty.\n";
            }

            // Validate stud_id format
            if (!Regex.IsMatch(stud_id, @"^\d{4}-2-\d{5}$"))
            {
                isValid = false;
                errorMessage += "Student ID must be in the format ####-2-#####.\n";
            }

            // Validate phone
            if (string.IsNullOrEmpty(phone))
            {
                isValid = false;
                errorMessage += "Phone number cannot be empty.\n";
            }

            // Validate password strength and match
            if (password.Length < 8 || !Regex.IsMatch(password, @"[\W_]"))
            {
                isValid = false;
                errorMessage += "Password must have at least 8 characters with special characters.\n";
            }
            if (password != password2)
            {
                isValid = false;
                errorMessage += "Passwords do not match.\n";
            }

            // Display error message if validation fails
            if (!isValid)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                // Proceed with form submission or other actions
                MessageBox.Show("Validation successful!");

                // Insert info to the database
                Connection conn = new Connection();
                SqlConnection sqlconn = conn.GetConnection();

                try
                {
                    string query = "INSERT INTO customer (fname, lname, username, phone, password) VALUES (@fname, @lname, @stud_id, @phone, @password)";

                    // Create a SqlCommand object to execute the query
                    using (SqlCommand command = new SqlCommand(query, sqlconn))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@fname", fname);
                        command.Parameters.AddWithValue("@lname", lname);
                        command.Parameters.AddWithValue("@stud_id", stud_id);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@password", password);

                        // Open the connection
                        sqlconn.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Customer inserted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Error inserting customer.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection, even if an error occurred
                    sqlconn.Close();
                }


            }

        }

        private void CloseBtn(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return to the main page?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Navigate to the Login class
                this.Hide(); // Hide the current form
                Login loginForm = new Login();
                loginForm.Show(); // Show the Login form
            }
        }
    }
}
