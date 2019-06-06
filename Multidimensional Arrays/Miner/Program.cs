namespace Miner
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            string[] commandsArgs = Console.ReadLine().Split();

            Queue<string> commands = new Queue<string>(commandsArgs);
            string[,] field = new string[fieldSize, fieldSize];
            int allCoal = 0;
            int collectedCoals = 0;
            bool isBreak = false;
            int startRow = -1;
            int startCol = -1;

            for (int rows = 0; rows < field.GetLength(0); rows++)
            {
                string[] rowAsString = Console.ReadLine().Split();

                for (int cols = 0; cols < rowAsString.Length; cols++)
                {
                    field[rows, cols] = rowAsString[cols];

                    if (rowAsString[cols] == "c")
                    {
                        allCoal++;
                    }
                    else if (rowAsString[cols] == "s")
                    {
                        startRow = rows;
                        startCol = cols;
                    }
                }
            }

            while (commands.Any())
            {
                string command = commands.Dequeue();

                if (command == "up" && startRow != 0)
                {
                    startRow--;
                }
                else if (command == "down" && startRow != field.GetLength(0) - 1)
                {
                    startRow++;
                }
                else if (command == "right" && startCol != field.GetLength(1) - 1)
                {
                    startCol++;
                }
                else if (command == "left" && startCol != 0)
                {
                    startCol--;
                }

                if (field[startRow, startCol] == "c")
                {
                    collectedCoals++;

                    field[startRow, startCol] = "*";
                }
                else if (field[startRow, startCol] == "e")
                {
                    isBreak = true;
                    break;
                }
            }

            if (isBreak)
            {
                Console.WriteLine($"Game over! ({startRow}, {startCol})");
            }
            else if (allCoal > collectedCoals && !isBreak)
            {
                Console.WriteLine($"{allCoal - collectedCoals} coals left. ({startRow}, {startCol})");
            }
            else if (allCoal == collectedCoals)
            {
                Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
            }
        }
    }
}
