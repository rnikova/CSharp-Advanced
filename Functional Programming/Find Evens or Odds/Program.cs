namespace Find_Evens_or_Odds
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int[] rangeArg = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = rangeArg[0];
            int end = rangeArg[1];

            string typeNumber = Console.ReadLine();

            List<int> numbers = new List<int>();

            Predicate<int> filter = x => typeNumber == "odd" ? x % 2 != 0 : x % 2 == 0;

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x=>filter(x))));
        }
    }
}
