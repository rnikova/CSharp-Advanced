namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split();
                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];
                double firstPressure = double.Parse(carData[5]);
                int firstAge = int.Parse(carData[6]);
                double secondPressure = double.Parse(carData[7]);
                int secondAge = int.Parse(carData[8]);
                double thirdPressure = double.Parse(carData[9]);
                int thirdAge = int.Parse(carData[10]);
                double fourthPressure = double.Parse(carData[11]);
                int fourthAge = int.Parse(carData[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire firstTire = new Tire(firstPressure, firstAge);
                Tire secondTire = new Tire(secondPressure, secondAge);
                Tire thirdTire = new Tire(thirdPressure, thirdAge);
                Tire fourthTire = new Tire(fourthPressure, fourthAge);

                Car car = new Car(model, engine, cargo, firstTire, secondTire, thirdTire, fourthTire);
                cars.Add(car);
            }

            string command = Console.ReadLine();


            if (command == "fragile")
            {
                List<Car> carsFragile = cars.Where(x => x.Cargo.Type == "fragile").ToList();

                foreach (var car in carsFragile)
                {
                    if (car.FirstTire.Pressure < 1.0 || car.SecondTire.Pressure < 1.0
                        || car.ThirdTire.Pressure < 1.0 || car.FourthTire.Pressure < 1.0)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else 
            {

                List<Car> carsFlamable = cars.Where(x => x.Cargo.Type == "flamable").ToList();

                foreach (var car in carsFlamable.Where(x => x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
