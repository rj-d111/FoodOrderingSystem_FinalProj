using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    public static class CustomerModel
    {
        public static int userID { get; set; }
        public static string Name { get; set; }
        public static string StudentID { get; set; }
        public static string Phone { get; set; }

    }

    public static class OrderModel
    {
        public static int OrderID { get; set; } 
        public static double OrderTotal { get; set; }
    }
}
