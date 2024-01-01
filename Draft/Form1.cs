using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\RJ\\source\\repos\\FoodOrderingSystem\\Draft\\Customer.mdf;Integrated Security=True");       
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CustomerDetails values(@Name,@PhoneNo)",sqlConnection);
            cmd.Parameters.AddWithValue("@Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@PhoneNo", txt_phoneno.Text);
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Successfully Saved");

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\RJ\\source\\repos\\FoodOrderingSystem\\Draft\\Customer.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CustomerDetails SET Name=@Name, PhoneNo=@PhoneNo WHERE CustomerID=@CustomerID", sqlConnection);
            cmd.Parameters.AddWithValue("@Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@PhoneNo", txt_phoneno.Text);
            cmd.Parameters.AddWithValue("@CustomerID", txt_customerid.Text);
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Successfully Updated");

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\RJ\\source\\repos\\FoodOrderingSystem\\Draft\\Customer.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE CustomerDetails WHERE CustomerID=@CustomerID", sqlConnection);
            cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txt_customerid.Text));
            cmd.ExecuteNonQuery();

            sqlConnection.Close ();
            MessageBox.Show("Successfully Deleted");
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\RJ\\source\\repos\\FoodOrderingSystem\\Draft\\Customer.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerDetails WHERE CustomerID=@CustomerID", sqlConnection);
            cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txt_customerid.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            customDataGridView1.DataSource = dt;

        }
    }
}
