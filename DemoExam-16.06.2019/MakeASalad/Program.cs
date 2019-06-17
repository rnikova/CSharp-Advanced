namespace MakeASalad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vegetablesArr = Console.ReadLine().Split();
            int[] caloriesArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<string, int> vegetablesCalories = new Dictionary<string, int>();
            vegetablesCalories.Add("tomato", 80);
            vegetablesCalories.Add("carrot", 136);
            vegetablesCalories.Add("lettuce", 109);
            vegetablesCalories.Add("potato", 215);

            Stack<int> calories = new Stack<int>(caloriesArr);
            Queue<string> vegetables = new Queue<string>(vegetablesArr);
            Queue<int> finishedSalads = new Queue<int>();


            while (vegetables.Any() && calories.Any())
            {
                int currentCalory = calories.Peek();

                while (currentCalory > 0 && vegetables.Any())
                {
                    string vegetable = vegetables.Dequeue();

                    if (vegetablesCalories.ContainsKey(vegetable))
                    {
                    currentCalory -= vegetablesCalories[vegetable];
                    }
                }

                finishedSalads.Enqueue(calories.Pop());
            }

            Console.WriteLine(string.Join(" ", finishedSalads));

            if (calories.Any())
            {
                Console.WriteLine(string.Join(" ", calories));
            }
            if (vegetables.Any())
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
        }
    }
}