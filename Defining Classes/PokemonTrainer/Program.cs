namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] trainerData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerData[0];
                string pokemonName = trainerData[1];
                string pokemonElement = trainerData[2];
                int pokemonHealth = int.Parse(trainerData[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                bool isTrainer = false;

                foreach (var tr in trainers)
                {
                    if (tr.Name == trainerName)
                    {
                        tr.Pokemons.Add(pokemon);
                        isTrainer = true;
                        break;
                    }
                }

                if (!isTrainer)
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    bool hasElelement = false;

                    foreach (var pokemon in trainer.Pokemons.Where(x => x.Health > 0))
                    {
                        if (pokemon.Element == input)
                        {
                            hasElelement = true;
                            break;
                        }
                    }

                    if (hasElelement)
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(x => x.Health -= 10);
                    }
                }

                input = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(x => x.Badges).ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
