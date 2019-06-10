namespace Cups_and_Bottles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(filledBottles);
            int wastedLitres = 0;
            int cup = 0;
            int bottle = 0;
            int water = bottle - cup;

            while (cups.Any() && bottles.Any())
            {
                cup = cups.Dequeue();
                bottle = bottles.Pop();
                water = bottle - cup;

                if (water > 0)
                {
                    wastedLitres += water;
                }
                else if(water < 0 && bottles.Any())
                {
                    while (water < 0)
                    {
                        bottle = bottles.Pop();
                        water += bottle;
                    }                  

                    if (water > 0)
                    {
                        wastedLitres += water;
                    }
                }
            }

            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedLitres}");
        }
    }
}
