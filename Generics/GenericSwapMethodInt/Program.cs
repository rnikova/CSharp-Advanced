namespace GenericSwapMethodStrings
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < linesCount; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.Add(input);
            }

            int[] indexesForSwap = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.SwapElements(indexesForSwap[0], indexesForSwap[1]);

            Console.WriteLine(box);
        }
    }
}
