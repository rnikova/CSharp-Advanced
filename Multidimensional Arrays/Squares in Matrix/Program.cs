namespace Squares_in_Matrix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[][] matrix = new string[dimentions[0]][];

            FillMatrix(dimentions, matrix);

            int count = 0;

            for (int row = 0; row < dimentions[0] - 1; row++)
            {
                for (int col = 0; col < dimentions[1] - 1; col++)
                {
                    if (matrix[row][col] == matrix[row][col + 1]
                        && matrix[row+1][col] == matrix[row+1][col+1]
                        && matrix[row][col] == matrix[row+1][col+1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"{count}");
        }

        public static void FillMatrix(int[] dimentions, string[][] matrix)
        {
            for (int row = 0; row < dimentions[0]; row++)
            {
                matrix[row] = Console.ReadLine().Split();
            }
        }
    }
}
