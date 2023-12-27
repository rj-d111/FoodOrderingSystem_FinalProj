using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem
{
    internal class MainClass
    {
        public static readonly string conString = "Data Source=DESKTOP-R398FHK\\SQLEXPRESS;Initial Catalog=grub-grab;Integrated Security=True";

        public static  SqlConnection con = new SqlConnection(conString);

    }
}
