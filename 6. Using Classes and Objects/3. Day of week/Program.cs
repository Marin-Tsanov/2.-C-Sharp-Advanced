using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Day_of_week
{
    class Program
    {
        static void Main()
        {
            DateTime dateValue = new DateTime();
            dateValue = DateTime.Today;

            Console.WriteLine(dateValue.ToString("ddd"));
        }
    }
}
