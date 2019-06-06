namespace Predicate_For_Names
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            Console.ReadLine().Split().Where(x => x.Length <= lenght).ToList().ForEach(Console.WriteLine);
        }
    }
}
