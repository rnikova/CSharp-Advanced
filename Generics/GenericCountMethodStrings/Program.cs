﻿namespace GenericCountMethodStrings
{

    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();

                box.Add(input);
            }

            string element = Console.ReadLine();

            int count = GetCountOfGreaterElement<string>(box.Data, element);

            Console.WriteLine(count);
        }

        public static int GetCountOfGreaterElement<T>(List<T> listWithData, T element)
            where T : IComparable
        {
            int count = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
