namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineData[0];
                int power = int.Parse(engineData[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                if (engineData.Length == 4)
                {
                    displacement = engineData[2];
                    efficiency = engineData[3];
                }
                else if (engineData.Length == 3)
                {
                    char[] data = engineData[2].ToCharArray();

                    if (char.IsDigit(data[0]))
                    {
                        displacement = engineData[2];
                    }
                    else
                    {
                        efficiency = engineData[2];
                    }
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);

            }
            
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                string engineModel = carData[1];
                string weight = "n/a";
                string color = "n/a";

                if (carData.Length == 4)
                {
                    weight = carData[2];
                    color = carData[3];
                }
                else if (carData.Length == 3)
                {
                    char[] data = carData[2].ToCharArray();

                    if (char.IsDigit(data[0]))
                    {
                        weight = carData[2];
                    }
                    else
                    {
                        color = carData[2];
                    }
                }

                foreach (var engine in engines)
                {
                    if (engine.Model == engineModel)
                    {
                        Car car = new Car(model, engine, weight, color);
                        cars.Add(car);
                        break;
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
