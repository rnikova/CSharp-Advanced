using System;
using System.Linq;
using System.Collections.Generic;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int operationCount = int.Parse(Console.ReadLine());

            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < operationCount; i++)
            {
                int[] operation = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (operation[0] == 1)
                {
                    elements.Push(operation[1]);
                }
                else if (operation[0] == 2)
                {
                    if (elements.Count != 0)
                    {
                        elements.Pop();
                    }
                }
                else if (operation[0] == 3 && elements.Count != 0)
                {
                    int maxElement = int.MinValue;

                    foreach (var item in elements)
                    {
                        if (item >= maxElement)
                        {
                            maxElement = item;
                        }
                    }
                    Console.WriteLine(maxElement);
                }
                else if (operation[0] == 4 && elements.Count != 0)
                {
                    int minElement = int.MaxValue;

                    foreach (var item in elements)
                    {
                        if (item <= minElement)
                        {
                            minElement = item;
                        }
                    }

                    Console.WriteLine(minElement);
                }
            }

            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
