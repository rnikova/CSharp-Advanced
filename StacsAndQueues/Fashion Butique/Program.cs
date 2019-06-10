namespace Fashion_Butique
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesAsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(clothesAsArray);
            int capacity = int.Parse(Console.ReadLine());

            int racks = 0;
            int currentRack = 0;
            int currentClothes = 0;

            while (clothes.Any())
            {
                currentClothes = clothes.Pop();
                currentRack += currentClothes;

                if (currentRack > capacity)
                {
                    racks++;
                    currentRack = currentClothes;
                }
                if (clothes.Count == 0)
                {
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
