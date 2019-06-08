using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Car
    {
        private List<Car> cars = new List<Car>();

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire FirstTire { get; set; }

        public Tire SecondTire { get; set; }
        
        public Tire ThirdTire { get; set; }

        public Tire FourthTire { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tire firstTire, Tire secondTire, Tire thirdTire, Tire fourthTire)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            FirstTire = firstTire;
            SecondTire = secondTire;
            ThirdTire = thirdTire;
            FourthTire = fourthTire;
        }

        public List<Car> GetFragileCargo()
        {
            return this.cars.Where(x => x.Cargo.Type == "fragile").ToList();
        }
        

        //public override string ToString()
        //{
        //    return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        //}
    }
}
