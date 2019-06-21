namespace TronRacers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[][] matrix = new char[matrixSize][];

            for (int i = 0; i < matrixSize; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();

                matrix[i] = row;
            }

            int[] firstPosition = CheckPositionOfPlayers(matrix, 'f');
            int[] secondPosition = CheckPositionOfPlayers(matrix, 's');

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string firstMoves = command[0];
                string secondMoves = command[1];

                bool gameOver = MovePlayers(matrix, firstMoves, secondMoves, firstPosition, secondPosition);

                if (gameOver)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        Console.WriteLine(string.Join("", matrix[row]));
                    }

                    break;
                }
            }
        }

        private static int[] CheckPositionOfPlayers(char[][] matrix, char player)
        {
            int[] lastPosition = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (matrix[row][col] == player)
                    {
                        lastPosition[0] = row;
                        lastPosition[1] = col;
                        break;
                    }
                }
            }

            return lastPosition;
        }

        private static bool MovePlayers(char[][] matrix, string firstMoves, string secondMoves, int[] firstPosition, int[] secondPosition)
        {
            bool isDead = false;
            bool isMoved = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (row == firstPosition[0] && col == firstPosition[1])
                    {
                        isDead = Move(matrix, firstMoves, row, col, firstPosition, 'f', 's');
                        isMoved = true;
                        break;
                    }
                }

                if (isMoved || isDead)
                {
                    break;
                }
            }

            isMoved = false;

            if (!isDead)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix[0].Length; col++)
                    {
                        if (row == secondPosition[0] && col == secondPosition[1])
                        {
                            isDead = Move(matrix, secondMoves, row, col, secondPosition, 's', 'f');
                            isMoved = true;
                            break;
                        }
                    }

                    if (isMoved)
                    {
                        break;
                    }
                }
            }

            return isDead;
        }

        private static bool Move(char[][] matrix, string moves, int row, int col, int[] position, char player, char anotherPlayer)
        {
            if (moves == "down")
            {
                if (row < matrix.GetLength(0) - 1)
                {
                    if (matrix[row + 1][col] == '*')
                    {
                        matrix[row + 1][col] = player;
                        position[0] = row + 1;
                        position[1] = col;
                    }
                    else if (matrix[row + 1][col] == anotherPlayer)
                    {
                        matrix[row + 1][col] = 'x';
                        return true;
                    }
                }
                else if (row == matrix.GetLength(0) - 1)
                {
                    if (matrix[0][col] == '*')
                    {
                        matrix[0][col] = player;
                        position[0] = 0;
                        position[1] = col;
                    }
                    else if (matrix[0][col] == anotherPlayer)
                    {
                        matrix[0][col] = 'x';
                        return true;
                    }
                }
            }
            else if (moves == "up")
            {
                if (row > 0)
                {
                    if (matrix[row - 1][col] == '*')
                    {
                        matrix[row - 1][col] = player;
                        position[0] = row - 1;
                        position[1] = col;
                    }
                    else if (matrix[row - 1][col] == anotherPlayer)
                    {
                        matrix[row - 1][col] = 'x';
                        return true;
                    }
                }
                else if (row == 0)
                {
                    if (matrix[matrix.GetLength(0) - 1][col] == '*')
                    {
                        matrix[matrix.GetLength(0) - 1][col] = player;
                        position[0] = matrix.GetLength(0) - 1;
                        position[1] = col;
                    }
                    else if (matrix[matrix.GetLength(0) - 1][col] == anotherPlayer)
                    {
                        matrix[matrix.GetLength(0) - 1][col] = 'x';
                        return true;
                    }
                }
            }
            else if (moves == "right")
            {
                if (col == matrix[row].Length - 1)
                {
                    if (matrix[row][0] == '*')
                    {
                        matrix[row][0] = player;
                        position[0] = row;
                        position[1] = 0;
                    }
                    else if (matrix[row][0] == anotherPlayer)
                    {
                        matrix[row][0] = 'x';
                        return true;
                    }
                }
                else if (col < matrix[row].Length - 1)
                {
                    if (matrix[row][col + 1] == '*')
                    {
                        matrix[row][col + 1] = player;
                        position[0] = row;
                        position[1] = col + 1;
                    }
                    else if (matrix[row][col + 1] == anotherPlayer)
                    {
                        matrix[row][col + 1] = 'x';
                        return true;
                    }
                }
            }
            else if (moves == "left")
            {
                if (col == 0)
                {
                    if (matrix[row][matrix[row].Length - 1] == '*')
                    {
                        matrix[row][matrix[row].Length - 1] = player;
                        position[0] = row;
                        position[1] = matrix[row].Length - 1;
                    }
                    else if (matrix[row][matrix[row].Length - 1] == anotherPlayer)
                    {
                        matrix[row][matrix[row].Length - 1] = 'x';
                        return true;
                    }
                }
                else if (col <= matrix[row].Length - 1)
                {
                    if (matrix[row][col - 1] == '*')
                    {
                        matrix[row][col - 1] = player;
                        position[0] = row;
                        position[1] = col - 1;
                    }
                    else if (matrix[row][col - 1] == anotherPlayer)
                    {
                        matrix[row][col - 1] = 'x';
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
