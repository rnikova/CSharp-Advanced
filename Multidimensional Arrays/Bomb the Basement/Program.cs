using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
            }

            int[] bomb = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombRow = bomb[0];
            int bombCol = bomb[1];
            int bombRadius = bomb[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));

                    if (distance <= bombRadius)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            int[][] secondMatrix = new int[cols][];

            for (int row = 0; row < cols; row++)
            {
                secondMatrix[row] = new int[rows];

                for (int col = 0; col < rows; col++)
                {
                    secondMatrix[row][col] = matrix[col][row];
                }

                secondMatrix[row] = secondMatrix[row].OrderByDescending(x => x).ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = secondMatrix[col][row];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join("", r))));
        }
    }
}
