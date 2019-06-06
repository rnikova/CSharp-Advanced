namespace DateModifier
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DateModifier
    {
        private string firstDate;

        private string secondDate;

        public string FirstDate { get; set; }

        public string SecondDate { get; set; }

        public double CalculateDates(string[] firstDateAsString, string[] secondDateAsString)
        {
            int firstYear = int.Parse(firstDateAsString[0]);
            int firstMonth = int.Parse(firstDateAsString[1]);
            int firstDays = int.Parse(firstDateAsString[2]);
            int secondYear = int.Parse(secondDateAsString[0]);
            int secondMonth = int.Parse(secondDateAsString[1]);
            int secondDays = int.Parse(secondDateAsString[2]);

            DateTime firstDate = new DateTime(firstYear, firstMonth, firstDays);
            DateTime secondDate = new DateTime(secondYear, secondMonth, secondDays);

            double diferenceDays = Math.Abs(firstDate.Subtract(secondDate).TotalDays);

            return diferenceDays;
        }
    }
}
