namespace CarSalesman
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private List<Engine> engines = new List<Engine>();

        public string Model { get; set; }

        public int Power { get; set; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; }

        public Engine(string model, int power, string displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public override string ToString()
        {
            return string.Format(
$@"{this.Model}:
    Power: {this.Power}
    Displacement: {this.Displacement}
    Efficiency: {this.Efficiency}");
        }
    }
}
