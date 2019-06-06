namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Family
    {
        private List<Person> people = new List<Person>();

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public List<Person> GetPeopleOver30()
        {
            return this.people.Where(x => x.Age > 30).ToList();
        }

        public Person GetOldestMember()
        {
            return this.people.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}