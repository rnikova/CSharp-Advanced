namespace Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> data;

        public int Count => this.data.Count;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            foreach (var hero in data)
            {
                if (hero.Name == name)
                {
                    this.data.Remove(hero);
                    break;
                }
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.data.OrderByDescending(x=>x.Item.Strength).First();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return this.data.OrderByDescending(x=>x.Item.Ability).First();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return this.data.OrderByDescending(x=>x.Item.Intelligence).First();
        }

        public override string ToString()
        {
            return $@"{string.Join(Environment.NewLine, this.data)}";
        }
    }
}
