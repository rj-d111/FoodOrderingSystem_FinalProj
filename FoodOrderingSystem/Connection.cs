using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem
{
    internal class Connection
    {
        public SqlConnection GetConnection()
        {
            string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RJ\source\repos\FoodOrderingSystem\FoodOrderingSystem\Grub-Grab.mdf;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connectionStr);
            return sqlConn;
        }
    }
}
