using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Common
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string ContactNumber { get; set; }
        public string OrderDate { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public int Price { get; set; }
    }
}
