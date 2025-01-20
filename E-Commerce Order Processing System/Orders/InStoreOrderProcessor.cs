using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Order_Processing_System.Orders
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            //Console.WriteLine("Provides a 5% discount on in-store orders.\n");
            return orderAmount - (0.05m * orderAmount);
        }

        Order order;
        public InStoreOrderProcessor(Order newOrder)
        {
            order = newOrder;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {order.OrderId} processed for {order.CustomerName}. Final amount after 5% discount: {CalculateDiscount(order.OrderAmount):c}");
        }
    }
}
