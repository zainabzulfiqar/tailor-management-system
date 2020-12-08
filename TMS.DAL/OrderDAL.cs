using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.DAL
{
    public class OrderDAL
    {
        public static List<Order> OrderList = new List<Order>();
        public static void AddNewOrder(Order o)
        {
            OrderList.Add(o);
        }
    }
}
