namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Trainer
    {
        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Where(x => x.Health > 0).ToList().Count}";
        }
    }
}
