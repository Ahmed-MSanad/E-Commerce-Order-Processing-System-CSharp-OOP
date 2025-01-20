using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Order_Processing_System.Orders
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            //Console.WriteLine("Provides a 10% discount on all online orders\n");
            return (orderAmount - (0.1m * orderAmount));
        }

        Order order;
        public OnlineOrderProcessor(Order newOrder)
        {
            order = newOrder;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {order.OrderId} processed for {order.CustomerName}. Final amount after 10% discount: {CalculateDiscount(order.OrderAmount):c}");
        }
    }
}
