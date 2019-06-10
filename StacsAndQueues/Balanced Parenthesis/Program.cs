using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Queue<char> rightSymbols = new Queue<char>();
        Queue<char> leftSymbols = new Queue<char>(); // ([   ])
        bool isValid = true;

        for (int i = 0; i < input.Length / 2; i++)
        {
            leftSymbols.Enqueue(input[i]);
            rightSymbols.Enqueue(input[input.Length - 1 - i]);
        }

        while (rightSymbols.Any())
        {
            if (leftSymbols.Peek() == '(' && rightSymbols.Peek() == ')')
            {
                leftSymbols.Dequeue();
                rightSymbols.Dequeue();
            }
            else if (leftSymbols.Peek() == '{' && rightSymbols.Peek() == '}')
            {
                leftSymbols.Dequeue();
                rightSymbols.Dequeue();
            }
            else if (leftSymbols.Peek() == '[' && rightSymbols.Peek() == ']')
            {
                leftSymbols.Dequeue();
                rightSymbols.Dequeue();
            }
            else
            {
                isValid = false;
                break;
            }
        }

        if (isValid)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}