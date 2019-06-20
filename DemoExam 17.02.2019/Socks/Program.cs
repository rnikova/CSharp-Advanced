namespace Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] leftSocksArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rigthSocksArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> leftSocks = new Stack<int>(leftSocksArr);
            Queue<int> rigthSocks = new Queue<int>(rigthSocksArr);

            List<int> pairs = new List<int>();

            while (leftSocks.Any() && rigthSocks.Any())
            {
                int left = leftSocks.Peek();
                int rigth = rigthSocks.Peek();

                if (left == rigth)
                {
                    rigthSocks.Dequeue();
                    leftSocks.Pop();
                    leftSocks.Push(left + 1);
                }
                else if (left < rigth)
                {
                    leftSocks.Pop();
                    continue;
                }
                else
                {
                    pairs.Add(left + rigth);
                    rigthSocks.Dequeue();
                    leftSocks.Pop();                   
                }
            }

            int biggestPair = pairs.Max();
            Console.WriteLine(biggestPair);
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
