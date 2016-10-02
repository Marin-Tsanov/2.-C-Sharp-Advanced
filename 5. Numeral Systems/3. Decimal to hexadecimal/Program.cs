using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Decimal_to_hexadecimal
{
    class Program
    {
        static void Main()
        {


            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(empty(n));
        }

        static string empty(BigInteger n)
        {
            char[] hex = "0123456789ABCDEF".ToCharArray();
            string empty = "";

            while (n != 0)
            {
                int m = (int)(n % 16);
                empty = (hex[m]) + empty;
                n = n / 16;
            }
            return empty;
        }
    }
}
