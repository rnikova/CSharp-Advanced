﻿namespace SpeedRacing
{
    class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public void Drive(double amountOfKm)
        {
            double requiredFuel = amountOfKm * FuelConsumptionPerKilometer;

            if (requiredFuel <= FuelAmount)
            {
                TravelledDistance += amountOfKm;
                FuelAmount -= requiredFuel;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        }
    }
}
