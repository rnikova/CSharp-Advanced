namespace TrojanInvasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            int[] spartansPlates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> plates = new List<int>(spartansPlates);
            Stack<int> trojans = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                int[] trojansWariors = Console.ReadLine().Split().Select(int.Parse).ToArray();

                AddTrojans(trojans, trojansWariors);

                if (i % 3 == 0)
                {
                    int newPLates = int.Parse(Console.ReadLine());
                    plates.Add(newPLates);
                }

                while (plates.Count > 0 && trojans.Any())
                {
                    int trojan = trojans.Pop();
                    int plate = plates[0];

                    if (trojan < plate)
                    {
                        plate -= trojan;
                        plates[0] = plate;
                    }
                    else if (trojan > plate)
                    {
                        trojan -= plate;
                        trojans.Push(trojan);
                        plates.RemoveAt(0);
                    }
                    else
                    {
                        plates.RemoveAt(0);
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (plates.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", trojans)}");
            }
            else if (plates.Any())
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }

        private static void AddTrojans(Stack<int> trojans, int[] trojansWariors)
        {
            foreach (var warior in trojansWariors)
            {
                trojans.Push(warior);
            }
        }
    }
}