namespace ExcelFunctions
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            string[][] matrix = new string[dimentions][];

            for (int row = 0; row < dimentions; row++)
            {
                string[] col = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                matrix[row] = col;
            }

            string[] command = Console.ReadLine().Split();

            if (command[0] == "hide")
            {
                HideHeader(matrix, command);
            }
            else if (command[0] == "sort")
            {
                SortHeader(matrix, command);
            }
            else if (command[0] == "filter")
            {
                FilterHearder(matrix, command);
            }
        }

        private static void FilterHearder(string[][] matrix, string[] command)
        {
            Console.WriteLine(string.Join(" | ", matrix[0]));

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (command[1] == matrix[0][col] && command[2] == matrix[row][col])
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row]));
                    }
                }
            }
        }

        private static void SortHeader(string[][] matrix, string[] command)
        {
            string[][] sortedMatrix = new string[matrix.GetLength(0)][];

            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (command[1] == matrix[0][col])
                {
                    sortedMatrix = matrix.Skip(1).OrderBy(x => x[col]).ToArray();
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row == 0)
                {
                    Console.WriteLine(string.Join(" | ", matrix[0]));
                }
                else
                {
                    Console.WriteLine(string.Join(" | ", sortedMatrix[row - 1]));
                }
            }
        }

        private static void HideHeader(string[][] matrix, string[] command)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[0][col] == command[1] && col == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row].Skip(1)));
                    }

                    return;
                }
                else if (matrix[0][col] == command[1] && col == matrix[0].Length-1)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row].Take(matrix[0].Length-1)));
                    }

                    return;
                }
                else if(matrix[0][col] == command[1] && col > 0 && col < matrix[0].Length-1)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int coll = 0; coll < matrix[row].Length; coll++)
                        {
                            if (matrix[0][coll] == command[1])
                            {
                                continue;
                            }

                            if (coll == matrix[row].Length - 1)
                            {
                                Console.Write(matrix[row][coll]);
                            }
                            else
                            {
                                Console.Write(matrix[row][coll] + " | ");
                            }
                        }

                        Console.WriteLine();
                    }

                    return;
                }
            }          
        }
    }
}