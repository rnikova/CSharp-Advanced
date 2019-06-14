namespace Tuple
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] nameAndAddressInput = Console.ReadLine().Split();

            string name = nameAndAddressInput[0] + " " + nameAndAddressInput[1];
            string address = nameAndAddressInput[2];

            Tuple<string, string> nameAndAddress = new Tuple<string, string>(name, address);

            string[] nameAndBeersInput = Console.ReadLine().Split();

            string secondPerson = nameAndBeersInput[0];
            int amountOfBeers = int.Parse(nameAndBeersInput[1]);

            Tuple<string, int> nameAndBeers = new Tuple<string, int>(secondPerson, amountOfBeers);

            string[] thirdInput = Console.ReadLine().Split();

            int intNumber = int.Parse(thirdInput[0]);
            double doubleNumber = double.Parse(thirdInput[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(intNumber, doubleNumber);

            Console.WriteLine(nameAndAddress);
            Console.WriteLine(nameAndBeers);
            Console.WriteLine(thirdTuple);
        }
    }
}
