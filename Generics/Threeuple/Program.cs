namespace Threeuple
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] fisrtInput = Console.ReadLine().Split();

            string name = fisrtInput[0] + " " + fisrtInput[1];
            string address = fisrtInput[2];
            string town = fisrtInput[3];

            Tuple<string, string, string> firstTuple = new Tuple<string, string, string>(name, address, town);

            string[] secondInput = Console.ReadLine().Split();

            string secondPerson = secondInput[0];
            int amountOfBeers = int.Parse(secondInput[1]);
            bool drunkOrNot = secondInput[2] == "drunk" ? true : false;

            Tuple<string, int, bool> secondTuple = new Tuple<string, int, bool>(secondPerson, amountOfBeers, drunkOrNot);

            string[] thirdInput = Console.ReadLine().Split();

            string thirdPerson = thirdInput[0];
            double balance = double.Parse(thirdInput[1]);
            string bank = thirdInput[2];

            Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(thirdPerson, balance, bank);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
