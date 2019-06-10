using System;
using System.Collections.Generic;

namespace Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carsArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var cars = new Queue<string>(carsArray);

            var servedCars = new Stack<string>();

            string[] inputCars = Console.ReadLine().Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            while (inputCars[0] != "End")
            {
                if (inputCars[0] == "Service")
                {
                    if (cars.Count != 0)
                    {
                        string carServed = cars.Peek();
                        servedCars.Push(carServed);
                        Console.WriteLine($"Vehicle {cars.Dequeue()} got served.");
                    }
                }
                else if (inputCars[0] == "CarInfo")
                {
                    string carToCheck = inputCars[1];
                    if (servedCars.Contains(carToCheck))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (inputCars[0] == "History")
                {
                    if (servedCars.Count != 0)
                    {
                        Console.WriteLine($"{string.Join(", ", servedCars)}");
                    }

                }

                inputCars = Console.ReadLine().Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (cars.Count != 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
        }
    }
}
