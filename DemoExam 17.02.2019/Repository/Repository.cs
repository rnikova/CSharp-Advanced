namespace Repository
{
    using System;
    using System.Collections.Generic;
    public class Repository
    {
        private List<Person> data;

        public int Count => this.data.Count;


        public Repository()
        {
            this.data = new List<Person>();
        }

        public void Add(Person person)
        {
            this.data.Add(person);
        }

        public Person Get(int id)
        {
            Person foundPerson = this.data[id];

            return foundPerson;
        }

        public bool Update(int id, Person newPerson)
        {
            if (id < this.data.Count)
            {
                this.data[id] = newPerson;

                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (id < this.data.Count)
            {
                this.data.Remove(data[id]);

                return true;
            }

            return false;
        }
    }
}
