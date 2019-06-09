namespace CarSalesman
{
    using System;

    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            return string.Format(
 $@"{this.Model}:
  {this.Engine}
  Weight: {this.Weight}
  Color: {this.Color}");
        }
    }
}
