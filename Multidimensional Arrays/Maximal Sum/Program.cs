namespace Maximal_Sum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix = new int[dimentions[0]][];

            for (int row = 0; row < dimentions[0]; row++)
            {
                int[] currentCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                matrix[row] = currentCol;
            }

            int sum = 0;
            int maxSum = int.MinValue;
            int[,] maxSumMatrix = new int[3, 3];
            int[,] sumMatrix = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < dimentions[1] - 2; col++)
                {
                    for (int currentRow = 0; currentRow < 3; currentRow++)
                    {
                        for (int currentCol = 0; currentCol < 3; currentCol++)
                        {
                            sumMatrix[currentRow, currentCol] = matrix[row + currentRow][col + currentCol];
                            sum += matrix[row + currentRow][col + currentCol];

                            if (maxSum < sum)
                            {
                                maxSum = sum;

                                for (int maxRow = 0; maxRow < 3; maxRow++)
                                {
                                    for (int maxCol = 0; maxCol < 3; maxCol++)
                                    {
                                        maxSumMatrix[maxRow, maxCol] = sumMatrix[maxRow, maxCol];
                                    }
                                }
                            }
                        }
                    }

                    sum = 0;
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = 0; row < maxSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{maxSumMatrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
