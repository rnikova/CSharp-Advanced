namespace SpaceStationRecruitment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SpaceStation
    {
        private List<Astronaut> data;

        public int Count => this.data.Count;

        public SpaceStation(string name, int capacity)
        {
            data = new List<Astronaut>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void Add(Astronaut astrounat)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(astrounat);
            }
        }

        public bool Remove(string name)
        {
            Astronaut austronautToRemove = this.data.FirstOrDefault(x => x.Name == name);

            if (austronautToRemove != null)
            {
                return true;
            }
            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            return this.data.OrderByDescending(x => x.Age).First();
        }

        public Astronaut GetAstronaut(string name)
        {
            return this.data.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            return $@"Astronauts working at Space Station {this.Name}:
{string.Join(Environment.NewLine, this.data)}";
        }
    }
}