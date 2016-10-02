using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3._2_Numeral_Systems
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(n));
        }

        static string DecimalToBinary(BigInteger n)
        {
            string empty = "";
            while (n != 0)
            {
                empty = (n % 2).ToString() + empty;
                n = n / 2;
            }
            return empty;
        }
    }
}
