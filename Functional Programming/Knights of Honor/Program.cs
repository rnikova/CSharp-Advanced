namespace Knights_of_Honor
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x.Select(y => $"Sir {y}")));

            print(names);
        }
    }
}
