namespace Stack
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            CustomStack<int> stack = new CustomStack<int>();

            while (command != "END")
            {
                string[] commands = command.Split(" ", 2);

                if (commands[0] == "Push")
                {
                    int[] numbers = commands[1].Split(", ").Select(int.Parse).ToArray();

                    stack.Push(numbers);
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var number in stack)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
