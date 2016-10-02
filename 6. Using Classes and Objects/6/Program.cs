using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Triangle_surface_by_side_and_altitude
{
    class Program
    {

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            c = c * (Math.PI / 180);

            
            double surface = (Math.Sin(c)*a*b)/2;
            Console.WriteLine("{0:F2}", surface);
        }

    }
}
