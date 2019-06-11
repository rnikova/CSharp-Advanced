namespace GenericBoxOfString
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();

                Box<string> box = new Box<string>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
