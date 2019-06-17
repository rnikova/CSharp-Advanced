namespace HealthyHeaven
{
    public class Vegetable
    {
        public string Name { get; set; }

        public int Calories { get; set; }

        public Vegetable(string name, int caroies)
        {
            this.Name = name;
            this.Calories = caroies;
        }

        public override string ToString()
        {
            return $" - {this.Name} have {this.Calories} calories";
        }
    }
}
