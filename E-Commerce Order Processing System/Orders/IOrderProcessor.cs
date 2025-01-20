using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Order_Processing_System.Orders
{
    internal interface IOrderProcessor
    {
        void ProcessOrder();
        decimal CalculateDiscount(decimal orderAmount);
    }
}
