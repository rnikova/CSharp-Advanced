namespace Reverse_And_Exclude
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int devisor = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % devisor != 0;

            Console.WriteLine(string.Join(" ", numbers.Where(x => filter(x))));
        }
    }
}
