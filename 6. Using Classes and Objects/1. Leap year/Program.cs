using System;

namespace _1.Leap_year
{
    class Program
    {
        static void Main()
        {
            const int Feb = 2;
            int year = int.Parse(Console.ReadLine());

            int daysInFebruary = System.DateTime.DaysInMonth(year,Feb);


            if (daysInFebruary==28)
            {
                Console.WriteLine("Common");
            }
            else
            {
                Console.WriteLine("Leap");
            }
        }
    }
}
