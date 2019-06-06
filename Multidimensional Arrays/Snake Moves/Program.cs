namespace Snake_Moves
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[] text = Console.ReadLine().ToCharArray();

            Queue<char> snakeText = new Queue<char>(text);
            char[,] snake = new char[dimentions[0], dimentions[1]];

            for (int row = 0; row < dimentions[0]; row++)
            {
                for (int col = 0; col < dimentions[1]; col++)
                {
                    char currentChar = snakeText.Dequeue();
                    snake[row, col] = currentChar;
                    snakeText.Enqueue(currentChar);
                }
            }

            for (int row = 0; row < dimentions[0]; row++)
            {
                for (int col = 0; col < dimentions[1]; col++)
                {
                    Console.Write($"{snake[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
