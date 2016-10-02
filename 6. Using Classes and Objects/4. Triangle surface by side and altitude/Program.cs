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
            double Lenght = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());

            double surface = (Lenght * Height) / 2;
            Console.WriteLine("{0:F2}", surface);
        }
        
    }
}
