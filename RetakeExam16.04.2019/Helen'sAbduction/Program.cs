namespace ExamPreparation_20_June_2019
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int parisEnergy = int.Parse(Console.ReadLine());
            int spartaRow = int.Parse(Console.ReadLine());

            char[][] spartaField = new char[spartaRow][];
            int parisRow = 0;
            int parisCol = 0;
            bool isWon = false;

            for (int i = 0; i < spartaRow; i++)
            {
                char[] spartaCol = Console.ReadLine().ToCharArray();

                if (spartaCol.Contains('P'))
                {
                    parisRow = i;

                    for (int c = 0; c < spartaCol.Length; c++)
                    {
                        if (spartaCol[c] == 'P')
                        {
                            parisCol = c;
                            spartaCol[c] = '-';
                            break;
                        }
                    }
                }

                spartaField[i] = spartaCol;
            }

            while (parisEnergy > 0)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string moveDirection = command[0];
                int spawnRow = int.Parse(command[1]);
                int spawnCol = int.Parse(command[2]);

                spartaField[spawnRow][spawnCol] = 'S';

                if (moveDirection == "up")
                {
                    if (parisRow - 1 >= 0)
                    {
                        parisRow--;
                    }
                }
                else if (moveDirection == "down")
                {
                    if (parisRow + 1 < spartaField.Length)
                    {
                        parisRow++;
                    }
                }
                else if (moveDirection == "left")
                {
                    if (parisCol - 1 >= 0)
                    {
                        parisCol--;
                    }
                }
                else if (moveDirection == "rigth")
                {
                    if (parisCol + 1 < spartaField[parisRow].Length)
                    {
                        parisCol++;
                    }
                }

                parisEnergy--;

                if (spartaField[parisRow][parisCol] == 'S')
                {
                    parisEnergy -= 2;

                    if (parisEnergy > 0)
                    {
                        spartaField[parisRow][parisCol] = '-';
                    }
                }

                if (spartaField[parisRow][parisCol] == 'H')
                {
                    spartaField[parisRow][parisCol] = '-';
                    isWon = true;
                    break;
                }

                if (parisEnergy <= 0)
                {
                    spartaField[parisRow][parisCol] = 'X';
                }
            }

            if (isWon)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }

            for (int row = 0; row < spartaField.Length; row++)
            {
                Console.WriteLine(string.Join("", spartaField[row]));
            }

        }

    }
}