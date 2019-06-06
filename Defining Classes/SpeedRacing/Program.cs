namespace SpeedRacing
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carsData = Console.ReadLine().Split();

                string carModel = carsData[0];
                double fuelAmount = double.Parse(carsData[1]);
                double fuelConsumptionPerKm = double.Parse(carsData[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumptionPerKm);

                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string carModel = command[1];
                double distance = double.Parse(command[2]);

                Car car = cars.FirstOrDefault(x => x.Model == carModel);
                car.Drive(distance);

                command = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
