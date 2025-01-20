using E_Commerce_Order_Processing_System.Orders;

namespace E_Commerce_Order_Processing_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n--- Enter Order Details ---");

            Order order = new Order();

            Console.Write("Enter Order ID: ");
            while(!int.TryParse(Console.ReadLine(), out order.OrderId))
            {
                Console.WriteLine("Invalid Order ID. Please enter a valid integer: ");
            }

            Console.Write("Enter Customer Name: ");
            order.CustomerName = Console.ReadLine();


            Console.Write("Enter Order Amount: ");
            while (!decimal.TryParse(Console.ReadLine(), out order.OrderAmount))
            {
                Console.WriteLine("Invalid Order Amount. Please enter a valid decimal value.");
            }


            Console.Write("Enter Order Type (0 for Online/ and 1 for In-Store): ");
            int orderType;


            while (!int.TryParse(Console.ReadLine(), out orderType) || (orderType != 0 && orderType != 1))
            {
                Console.WriteLine("Invalid Order Type. Please Enter Order Type (0 for Online/ and 1 for In-Store):");
            }


            order.eorderType = (EorderType)orderType;

            Console.WriteLine("\nOrder added successfully!");

            
            if (order.eorderType == EorderType.online) {
                OnlineOrderProcessor onlineOrderProcessor = new OnlineOrderProcessor(order);
                onlineOrderProcessor.ProcessOrder();
            }
            else
            {
                InStoreOrderProcessor inStoreOrderProcessor = new InStoreOrderProcessor(order);
                inStoreOrderProcessor.ProcessOrder();
            }
            
        }
    }
}
