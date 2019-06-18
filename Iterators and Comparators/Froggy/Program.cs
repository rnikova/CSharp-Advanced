namespace Froggy
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Lake lake = new Lake(numbers);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
