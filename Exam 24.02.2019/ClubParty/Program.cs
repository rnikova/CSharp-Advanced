namespace ClubParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();

            Stack<string> halls = new Stack<string>(input);
            Queue<string> fullHalls = new Queue<string>();
            List<int> people = new List<int>();
            int maxPeople = capacity;

            while (halls.Any())
            {
                string currentHall = halls.Peek();

                bool isNumber = int.TryParse(currentHall, out int currentNumber);

                if (!isNumber)
                {
                    fullHalls.Enqueue(currentHall);
                    halls.Pop();
                }
                else if(isNumber && fullHalls.Any())
                {
                    maxPeople -= currentNumber; 

                    if (maxPeople >= 0)
                    {
                        people.Add(currentNumber);
                        halls.Pop();
                    }
                    else
                    {
                        Console.WriteLine($"{fullHalls.Dequeue()} -> {string.Join(", ", people)}");
                        people = new List<int>();
                        maxPeople = capacity;
                    }
                }
                else
                {
                    halls.Pop();
                }
            }
               
        }
    }
}
