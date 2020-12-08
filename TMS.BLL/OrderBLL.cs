using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.BLL
{
    public class OrderBLL
    {
        public void AddNewOrder(Order o)
        {
            TMS.DAL.OrderDAL.AddNewOrder(o);
        }

        public List<Order> GetPendingOrders()
        {
            return TMS.DAL.OrderDAL.OrderList;
        }
    }
}
