namespace DateModifier
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstDateAsString = Console.ReadLine().Split();
            string[] secondDateAsString = Console.ReadLine().Split();

            DateModifier dateModifier = new DateModifier();

            double result = dateModifier.CalculateDates(firstDateAsString, secondDateAsString);

            Console.WriteLine(result);
        }
    }
}
