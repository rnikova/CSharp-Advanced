namespace Custom_Comparator
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] evenNumbers = numbers.Where(x => x % 2 == 0).OrderBy(n => n).ToArray();
            int[] oddNumbers = numbers.Where(x => x % 2 != 0).OrderBy(n => n).ToArray();

            Func<int, int, int> sortFunc = (a, b) => a.CompareTo(b);
            Action<int[]> print = x => Console.Write(string.Join(" ", x));
            Array.Sort(evenNumbers, new Comparison<int>(sortFunc));
            Array.Sort(oddNumbers, new Comparison<int>(sortFunc));

            print(evenNumbers);
            Console.Write(" ");
            print(oddNumbers);
        }
    }
}
