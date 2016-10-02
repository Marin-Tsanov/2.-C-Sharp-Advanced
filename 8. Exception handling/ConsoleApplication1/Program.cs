using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void TestTryFinally()
        {
            Console.WriteLine("Code executed before try-finally.");

            try
            {
                int.Parse(Console.ReadLine());
                Console.WriteLine("Parsing was successful.");
                return; // Exit from the current method
            }
            catch (FormatException)
            {
                Console.WriteLine("Parsing failed!");
            }
            finally
            {
                Console.WriteLine("This cleanup code is always executed.");
            }

            Console.WriteLine(
              "This code is after the try-finally block.");
        }

        static void Main()
        {
            TestTryFinally();
        }
    }
}

