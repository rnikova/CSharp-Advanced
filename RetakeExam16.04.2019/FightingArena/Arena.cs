namespace FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count => this.gladiators.Count;

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiatorToRemove = gladiators.FirstOrDefault(x => x.Name == name);

            this.gladiators.Remove(gladiatorToRemove);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return this.gladiators.OrderByDescending(x => x.GetStatPower()).First(); ;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return this.gladiators.OrderByDescending(x => x.GetWeaponPower()).First();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return this.gladiators.OrderByDescending(x => x.GetTotalPower()).First();
        }

        public override string ToString()
        {
            return $@"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}
