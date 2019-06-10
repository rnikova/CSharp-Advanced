namespace Fast_Food
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] ordersAsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var orders = new Queue<int>(ordersAsArray);
            int bigestOrder = int.MinValue;

            foreach (var item in orders)
            {
                if (item > bigestOrder)
                {
                    bigestOrder = item;
                }
            }

            Console.WriteLine(bigestOrder);

            while (quantity > 0 && orders.Any())
            {
                if ((quantity -= orders.Peek()) >= 0)
                {
                    //quantity -= orders.Peek();
                    orders.Dequeue();
                }
                else
                {
                    string leftOrders = string.Empty;

                    foreach (var item in orders)
                    {
                        leftOrders += item + " ";
                    }

                    Console.WriteLine($"Orders left: {leftOrders}");
                    break;
                }
            }

            if (quantity >= 0)
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
