namespace TheGarden
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());

            string[][] garden = new string[rowCount][];

            for (int row = 0; row < rowCount; row++)
            {
                string[] currentCol = Console.ReadLine().Split();

                garden[row] = currentCol;
            }

            int harmedVeg = 0;
            int[] vegetables = new int[3];

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Harvest")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);

                    HarvestVegetables(garden, row, col, vegetables);
                }
                else if (command[0] == "Mole")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    string direction = command[3];

                    harmedVeg = EatenByTheMole(garden, row, col, direction, harmedVeg);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(Environment.NewLine, garden.Select(r => string.Join(" ", r))));
            Console.WriteLine($"Carrots: {vegetables[0]}");
            Console.WriteLine($"Potatoes: {vegetables[1]}");
            Console.WriteLine($"Lettuce: {vegetables[2]}");
            Console.WriteLine($"Harmed vegetables: {harmedVeg}");
        }

        private static int EatenByTheMole(string[][] garden, int row, int col, string direction, int harmedVeg)
        {
            if (row >= 0 && row < garden.GetLength(0) && col >= 0 && col < garden[row].Length)
            {
                if (direction == "up")
                {
                    for (int r = row; r >= 0; r -= 2)
                    {
                        if (garden[r][col] != " ")
                        {
                            harmedVeg++;
                            garden[r][col] = " ";
                        }
                    }
                }
                else if (direction == "down")
                {
                    for (int r = row; r < garden.GetLength(0); r += 2)
                    {
                        if (garden[r][col] != " ")
                        {
                            harmedVeg++;
                            garden[r][col] = " ";
                        }
                    }
                }
                else if (direction == "right")
                {
                    for (int c = col; c < garden[row].Length; c += 2)
                    {
                        if (garden[row][c] != " ")
                        {
                            harmedVeg++;
                            garden[row][c] = " ";
                        }
                    }
                }
                else if (direction == "left")
                {
                    for (int c = col; c >= 0; c -= 2)
                    {
                        if (garden[row][c] != " ")
                        {
                            harmedVeg++;
                            garden[row][c] = " ";
                        }
                    }
                }
            }
                return harmedVeg;
        }

        public static int[] HarvestVegetables(string[][] garden, int row, int col,int[] vegetables)
        {
            if (row >= 0 && row < garden.GetLength(0) && col >= 0 && col < garden[row].Length)
            {
                if (garden[row][col] == "L")
                {
                    vegetables[2]++;
                    garden[row][col] = " ";
                }
                else if (garden[row][col] == "P")
                {
                    vegetables[1]++;
                    garden[row][col] = " ";
                }
                else if (garden[row][col] == "C")
                {
                    vegetables[0]++;
                    garden[row][col] = " ";
                }
            }

            return vegetables;
        }
    }
}
