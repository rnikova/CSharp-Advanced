namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < membersCount; i++)
            {
                string[] personArg = Console.ReadLine().Split();
                Person person = new Person(personArg[0], int.Parse(personArg[1]));
                family.AddMember(person);
            }

            List<Person> peopleOver30 = family.GetPeopleOver30().OrderBy(x => x.Name).ToList();

            foreach (var member in peopleOver30)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
