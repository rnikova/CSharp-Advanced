namespace RawData
{
    using System.Collections.Generic;

    public class Tire
    {
        public int Age { get; set; }

        public double Pressure { get; set; }

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
        
        //public List<Tire> tires = new List<Tire>();

        //public void AddTires(Tire tire)
        //{
        //    if (tires.Count < 4)
        //    {
        //        this.tires.Add(tire);
        //    }
        //}
    }
}
