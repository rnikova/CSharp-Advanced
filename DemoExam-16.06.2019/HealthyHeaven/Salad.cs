namespace HealthyHeaven
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Salad
    {
        private List<Vegetable> products;

        public string SaladName { get; set; }

        public Salad(string saladName)
        {
            products = new List<Vegetable>();
            this.SaladName = saladName;
        }

        public void Add(Vegetable product)
        {
            this.products.Add(product);
        }

        public int GetTotalCalories()
        {
            return this.products.Sum(x => x.Calories);
        }

        public int GetProductCount()
        {
            return this.products.Count;
        }

        public override string ToString()
        {
            return $@"* Salad {this.SaladName} is {GetTotalCalories()} calories and have {GetProductCount()} products:
{string.Join(Environment.NewLine, products)}";
        }
    }
}
