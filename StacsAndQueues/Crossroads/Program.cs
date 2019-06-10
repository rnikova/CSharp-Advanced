using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {

        // 71 точки
        int durationGreenLight = int.Parse(Console.ReadLine());
        int durationFreeWindow = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        Queue<string> cars = new Queue<string>();

        while (command != "END")
        {
            cars.Enqueue(command);
            command = Console.ReadLine();
        }

        int passedCars = 0;
        int currentTime = durationGreenLight;
        bool hasCrashed = false;
        string hitChar = string.Empty;
        string currentCarName = string.Empty;
        int currentCar = 0;

        while (cars.Any())
        {
            currentCarName = cars.Dequeue();

            if (currentCarName == "green")
            {
                currentTime = durationGreenLight;
                continue;
            }
            else
            {
                currentCar = currentCarName.Length;
                currentTime -= currentCar;
            }

            if (currentTime > 0)
            {
                passedCars++;
            }
            else
            {
                currentTime += durationFreeWindow;

                if (currentTime < 0)
                {
                    hitChar = currentCarName.Substring((currentCar + currentTime), 1);
                    hasCrashed = true;
                    break;
                }
                else
                {
                    passedCars++;
                    break;
                }
            }
        }

        if (hasCrashed)
        {
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{currentCarName} was hit at {hitChar}.");
        }
        else
        {
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}

