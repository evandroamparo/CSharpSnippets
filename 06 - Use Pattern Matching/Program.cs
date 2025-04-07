using System;

namespace PatternMatchingExample
{
    public class Order
    {
        public int Items { get; set; }
        public decimal TotalValue { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Order order = new() { Items = 3, TotalValue = 100m };

            // Traditional if statement without pattern matching:
            if (order != null && order.Items > 0 && order.TotalValue > 50)
            {
                Console.WriteLine("Order qualifies for discount.");
            }
            else
            {
                Console.WriteLine("Order does not qualify for discount.");
            }

            // Using pattern matching to check multiple properties:
            if (order is { Items: > 0, TotalValue: > 50 })
            {
                Console.WriteLine("Order qualifies for discount.");
            }
            else
            {
                Console.WriteLine("Order does not qualify for discount.");
            }
        }
    }
}
