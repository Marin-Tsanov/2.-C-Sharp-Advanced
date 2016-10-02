using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static void Main()
        {
            int m = Multiply(5, 10);
            Console.WriteLine(m);
        }
    }
}
