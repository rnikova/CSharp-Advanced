namespace Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] lair = new char[dimentions[0], dimentions[1]];
            char[,] currentLair = new char[dimentions[0], dimentions[1]];
            int playerRow = -1;
            int playerCol = -1;
            bool isDead = false;

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                char[] rowAsChar = Console.ReadLine().ToCharArray();

                for (int col = 0; col < rowAsChar.Length; col++)
                {
                    lair[row, col] = rowAsChar[col];
                    currentLair[row, col] = rowAsChar[col];

                    if (rowAsChar[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] commandsArr = Console.ReadLine().ToCharArray();

            Queue<char> commands = new Queue<char>(commandsArr);

            while (commands.Any())
            {
                char currentCommand = commands.Dequeue();

                if (currentCommand == 'U' && playerRow > 0)
                {
                    if (currentLair[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                        currentLair[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        currentLair[playerRow, playerCol] = '.';
                    }
                    playerRow--;
                    currentLair[playerRow, playerCol] = 'P';
                }
                else if (currentCommand == 'D' && playerRow < lair.GetLength(0) - 1)
                {
                    if (currentLair[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                        currentLair[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        currentLair[playerRow, playerCol] = '.';
                    }
                    playerRow++;
                    currentLair[playerRow, playerCol] = 'P';
                }
                else if (currentCommand == 'L' && playerCol > 0)
                {
                    if (currentLair[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                        currentLair[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        currentLair[playerRow, playerCol] = '.';
                    }
                    playerCol--;
                    currentLair[playerRow, playerCol] = 'P';
                }
                else if (currentCommand == 'R' && playerCol < lair.GetLength(1) - 1)
                {
                    if (currentLair[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                        currentLair[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        currentLair[playerRow, playerCol] = '.';
                    }
                    playerCol++;
                    currentLair[playerRow, playerCol] = 'P';
                }

                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row, col] == 'B')
                        {
                            if (row > 0)
                            {
                                currentLair[row - 1, col] = 'B';

                                if (lair[row - 1, col] == 'P')
                                {
                                    isDead = true;
                                    break;
                                }
                            }

                            if (row < lair.GetLength(0) - 1)
                            {
                                currentLair[row + 1, col] = 'B';

                                if (lair[row + 1, col] == 'P')
                                {
                                    isDead = true;
                                    break;
                                }
                            }

                            if (col > 0)
                            {
                                currentLair[row, col - 1] = 'B';

                                if (lair[row, col - 1] == 'P')
                                {
                                    isDead = true;
                                    break;
                                }
                            }

                            if (col < lair.GetLength(1) - 1)
                            {
                                currentLair[row, col + 1] = 'B';

                                if (lair[row, col + 1] == 'P')
                                {
                                    isDead = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (isDead)
                    {
                        break;
                    }
                }

                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        lair[row, col] = currentLair[row, col];
                    }
                }

                if (isDead)
                {
                    break;
                }

            }

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (!isDead && lair[row, col] == 'P')
                    {
                        lair[row, col] = '.';
                    }

                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }

            if (isDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
            else
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }
    }
}
