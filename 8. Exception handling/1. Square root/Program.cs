using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Square_root
{
    class Program
    {
        static void Sqrt(double number)
        {
            if (number < 0)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            double sqrtNumber = Math.Sqrt(number);
          Console.WriteLine("{0:F3}", sqrtNumber);
        }

        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                Sqrt(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
                
            }
            finally
            {
                Console.WriteLine("Good bye");
            }     
        }
    }
}
