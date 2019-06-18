using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                Person person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine().Split();
            }

            int indexOfPerson = int.Parse(Console.ReadLine());
            int countOfMachesPeople = 1;

            Person personOnIndex = people[indexOfPerson - 1];

            foreach (var item in people)
            {
                if (item == personOnIndex)
                {
                    continue;
                }
                if (item.CompareTo(personOnIndex) == 0)
                {
                    countOfMachesPeople++;
                }
            }

            if (countOfMachesPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMachesPeople} {people.Count - countOfMachesPeople} {people.Count}");
            }
        }
    }
}
