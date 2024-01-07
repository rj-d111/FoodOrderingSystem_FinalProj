using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Draft
{
    public static class Logout
    {
        public static void ShowLogoutConfirmation(Form form)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Reset the values
                ResetValues();
                // Perform any necessary logout actions (e.g., clear session data)

                // Navigate to Login.cs
                Login loginForm = new Login();  // Assuming FormLogin is the name of your login form
                loginForm.Show();

                // Close the current form
                form.Hide();
            }
        }
        public static void ResetValues()
        {
            CustomerModel.userID = 0;
            CustomerModel.Name = null;
            CustomerModel.StudentID = null;
            CustomerModel.Phone = null;

            OrderModel.OrderID = 0;
            OrderModel.OrderTotal = 0.0;
            OrderModel.TenderAmount = 0.0;
            OrderModel.PaymentDate = DateTime.MinValue;
        }
    }
}
