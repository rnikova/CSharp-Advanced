namespace HealthyHeaven
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Restaurant
    {
        private List<Salad> data;

        public string RestaurantName { get; set; }

        public Restaurant(string restaurantName)
        {
            this.RestaurantName = restaurantName;
            this.data = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            this.data.Add(salad);
        }

        public bool Buy(string name)
        {
            if (this.data.Where(x => x.SaladName == name).ToList().Count > 0)
            {
                this.data.Remove(this.data.Where(x => x.SaladName == name).First());
                return true;
            }
            else
            {
                return false;
            }
        }

        public Salad GetHealthiestSalad()
        {
            return this.data.OrderBy(x => x.GetTotalCalories()).First();
        }

        public string GenerateMenu()
        {
            return $@"{this.RestaurantName} have {this.data.Count} salads:
{string.Join(Environment.NewLine, data)}";

        }
    }
}
        
    
