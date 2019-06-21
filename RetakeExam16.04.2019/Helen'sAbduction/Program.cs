namespace Helen_sAbduction
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int parisEnergy = int.Parse(Console.ReadLine());
            int matrixSize = int.Parse(Console.ReadLine());

            char[][] sparta = new char[matrixSize][];
            int[] parisIndex = new int[2];
            int[] helenIndex = new int[2];
            bool isWon = false;

            for (int row = 0; row < matrixSize; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                if (cols.Contains('P') || cols.Contains('H'))
                {
                    for (int i = 0; i < cols.Length; i++)
                    {
                        if (cols[i] == 'P')
                        {
                            parisIndex[0] = row;
                            parisIndex[1] = i;
                            cols[i] = '-';
                        }
                        else if (cols[i] == 'H')
                        {
                            helenIndex[0] = row;
                            helenIndex[1] = i;
                        }
                    }
                }

                sparta[row] = cols;
            }

            while (parisEnergy > 0)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string move = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                sparta[row][col] = 'S';

                MoveDirection(sparta, move, parisIndex);
                parisEnergy--;

                char spartan = sparta[parisIndex[0]][parisIndex[1]];

                if (spartan == 'S')
                {
                    parisEnergy -= 2;
                }
                else if (spartan == 'H')
                {
                    isWon = true;
                    sparta[parisIndex[0]][parisIndex[1]] = '-';
                    break;
                }

                if (parisEnergy <= 0)
                {
                    sparta[parisIndex[0]][parisIndex[1]] = 'X';
                    break;
                }
            }

            if (isWon)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisIndex[0]};{parisIndex[1]}.");
            }

            for (int row = 0; row < sparta.Length; row++)
            {
                Console.WriteLine(string.Join("", sparta[row]));
            }
        }

        private static void MoveDirection(char[][] sparta, string move, int[] parisIndex)
        {
            if (move == "up")
            {
                if (parisIndex[0] - 1 >= 0)
                {
                    parisIndex[0]--;
                }
            }
            else if (move == "down")
            {
                if (parisIndex[0] + 1 < sparta.Length)
                {
                    parisIndex[0]++;
                }
            }
            else if (move == "left")
            {
                if (parisIndex[1] - 1 >= 0)
                {
                    parisIndex[1]--;
                }
            }
            else if (move == "rigth")
            {
                if (parisIndex[1] + 1 < sparta[parisIndex[0]].Length)
                {
                    parisIndex[1]++;
                }
            }
        }
    }
}