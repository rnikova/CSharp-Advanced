namespace EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                var person = new Person(name, age);
                people.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}
