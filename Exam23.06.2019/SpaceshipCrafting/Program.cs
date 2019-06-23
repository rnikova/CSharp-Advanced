namespace SpaceshipCrafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int glass = 25;
            int aluminium = 50;
            int lithium = 75;
            int carbonFiber = 100;

            int[] liquidsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] physicalsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> liquids = new Queue<int>(liquidsArr);
            List<int> physicals = new List<int>(physicalsArr);

            int glassCount = 0;
            int aluminiumCount = 0;
            int lithiumCount = 0;
            int carbonFiberCount = 0;

            while (liquids.Any() && physicals.Count > 0)
            {
                int currentLiquid = liquids.Dequeue();
                int currentPhysical = physicals[physicals.Count - 1];

                int result = currentLiquid + currentPhysical;

                if (result == glass)
                {
                    glassCount++;
                    physicals.Remove(currentPhysical);
                }
                else if (result == aluminium)
                {
                    aluminiumCount++;
                    physicals.Remove(currentPhysical);
                }
                else if (result == lithium)
                {
                    lithiumCount++;
                    physicals.Remove(currentPhysical);
                }
                else if (result == carbonFiber)
                {
                    carbonFiberCount++;
                    physicals.Remove(currentPhysical);
                }
                else
                {
                    physicals[physicals.Count - 1] += 3;
                }
            }

            if (glassCount > 0 && aluminiumCount > 0 && lithiumCount > 0 && carbonFiberCount > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (physicals.Count > 0)
            {
                physicals.Reverse();
                Console.WriteLine($"Physical items left: {string.Join(", ", physicals)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            Console.WriteLine($"Aluminium: {aluminiumCount}");
            Console.WriteLine($"Carbon fiber: {carbonFiberCount}");
            Console.WriteLine($"Glass: {glassCount}");
            Console.WriteLine($"Lithium: {lithiumCount}");
        }
    }
}
