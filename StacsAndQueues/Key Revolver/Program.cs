namespace Key_Revolver
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barellSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int money = int.Parse(Console.ReadLine());

            Stack<int> bulletsValue = new Stack<int>(bullets);
            Stack<int> locksValue = new Stack<int>(locks);
            int count = 0;
            int bulletCount = bulletsValue.Count();

            while (bulletsValue.Any() && locksValue.Any())
            {
                int bulet = bulletsValue.Pop();
                int @lock = locksValue.Pop();

                if (bulet > @lock)
                {
                    Console.WriteLine("Ping!");
                    locksValue.Push(@lock);
                }
                else
                {
                    Console.WriteLine("Bang!");
                }

                count++;

                if (count == barellSize && bulletsValue.Any())
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }
            }

            if (bulletsValue.Any() || !bulletsValue.Any() && !locksValue.Any())
            {
                int leftMoney = money - (bulletCount - bulletsValue.Count) * bulletPrice;
                Console.WriteLine($"{bulletsValue.Count} bullets left. Earned ${leftMoney}");
            }
            else if (locksValue.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksValue.Count}");
            }
        }
    }
}
