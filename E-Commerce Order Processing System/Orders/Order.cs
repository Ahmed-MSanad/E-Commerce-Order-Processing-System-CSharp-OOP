using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Order_Processing_System.Orders
{
    internal class Order
    {
        public int OrderId;
        public string CustomerName;
        public decimal OrderAmount;
        public IOrderProcessor OrderProcessor;
        public EorderType eorderType;

    }
}
