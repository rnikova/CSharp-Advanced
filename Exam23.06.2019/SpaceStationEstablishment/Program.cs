namespace SpaceStationEstablishment
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[][] matrix = new char[matrixSize][];
            int stephenRow = 0;
            int stephenCol = 0;
            int collectedStars = 0;
            bool goesToTheVoid = false;


            for (int row = 0; row < matrixSize; row++)
            {
                char[] col = Console.ReadLine().ToCharArray();

                if (col.Contains('S'))
                {
                    stephenRow = row;
                    stephenCol = Array.IndexOf(col, 'S');
                }

                matrix[row] = col;
            }

            matrix[stephenRow][stephenCol] = '-';

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "right")
                {
                    if (stephenCol + 1 < matrix[stephenCol].Length)
                    {
                        stephenCol++;
                    }
                    else
                    {
                        goesToTheVoid = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (stephenCol - 1 >= 0)
                    {
                        stephenCol--;
                    }
                    else
                    {
                        goesToTheVoid = true;
                        break;
                    }
                }
                else if (command == "up")
                {
                    if (stephenRow - 1 >= 0)
                    {
                        stephenRow--;
                    }
                    else
                    {
                        goesToTheVoid = true;
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (stephenRow + 1 < matrix.Length)
                    {
                        stephenRow++;
                    }
                    else
                    {
                        goesToTheVoid = true;
                        break;
                    }
                }

                if (char.IsDigit(matrix[stephenRow][stephenCol]))
                {
                    collectedStars += int.Parse(matrix[stephenRow][stephenCol].ToString());
                    matrix[stephenRow][stephenCol] = '-';
                }
                else if (matrix[stephenRow][stephenCol] == 'O')
                {
                    matrix[stephenRow][stephenCol] = '-';

                    for (int row = 0; row < matrix.Length; row++)
                    {
                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            if (matrix[row][col] == 'O')
                            {
                                stephenRow = row;
                                stephenCol = col;
                                matrix[row][col] = '-';
                                break;
                            }
                        }
                    }
                }

                if (goesToTheVoid || collectedStars >= 50)
                {

                    matrix[stephenRow][stephenCol] = 'S';
                    break;
                }
            }

            if (goesToTheVoid)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {collectedStars}");

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join("", matrix[row]));
            }
        }
    }
}