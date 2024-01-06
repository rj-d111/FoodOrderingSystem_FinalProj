using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    public class Connection
    {
        public SqlConnection GetConnection()
        {
            string connectionStr = "Data Source=DESKTOP-R398FHK\\SQLEXPRESS;Initial Catalog=grub-grab;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connectionStr);
            return sqlConn;
        }
    }
}
