namespace Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbersInArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(numbersInArray);

            for (int i = 0; i < command[1]; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(command[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestElement = int.MaxValue;

                foreach (var num in numbers)
                {
                    if (num < smallestElement)
                    {
                        smallestElement = num;
                    }
                }

                if (numbers.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine($"{smallestElement}");
                }
            }
        }
    }
}
