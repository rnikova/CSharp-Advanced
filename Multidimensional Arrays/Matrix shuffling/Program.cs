namespace Matrix_shuffling
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[][] matrix = new string[dimentions[0]][];

            FillTheMatrix(matrix, dimentions);

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                if (command[0] != "swap" || command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    SwapMatrixElement(matrix, command, dimentions);
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

        }

        private static void SwapMatrixElement(string[][] matrix, string[] command, int[] dimentions)
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int swapRow = int.Parse(command[3]);
            int swapCol = int.Parse(command[4]);

            if (row < dimentions[0] && row > -1 
                && col < dimentions[1] && col > -1
                && swapRow < dimentions[0] && swapRow > -1 
                && swapCol < dimentions[1] && swapCol > -1)
            {
                string text = matrix[row][col];

                matrix[row][col] = matrix[swapRow][swapCol];
                matrix[swapRow][swapCol] = text;

                for (int rows = 0; rows < dimentions[0]; rows++)
                {
                    for (int cols = 0; cols < dimentions[1]; cols++)
                    {
                        Console.Write($"{matrix[rows][cols]} ");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        public static void FillTheMatrix(string[][] matrix, int[] dimentions)
        {
            for (int row = 0; row < dimentions[0]; row++)
            {
                string[] currentCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                matrix[row] = currentCol;
            }
        }
    }
}
