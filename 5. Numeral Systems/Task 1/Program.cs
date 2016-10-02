using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculation_Problem
{
    class Program
    {
        static void Main()
        {
            BigInteger sum = 0;

            char[] a = Console.ReadLine().ToCharArray();
            Array.Reverse(a);

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + (BigInteger)((a[i] - 'a') * (Math.Pow(26, i)));
            }


            string sing = Console.ReadLine();

            BigInteger sum1 = 0;

            char[] b = Console.ReadLine().ToCharArray();
            Array.Reverse(b);

            for (int i = 0; i < b.Length; i++)
            {
                sum1 += (BigInteger)((b[i] - '0') * (Math.Pow(7, i)));
            }

            if (sing == "+")
            {
                BigInteger resultDec = sum + sum1;

                string empty = "";
                while (resultDec != 0)
                {
                    empty = (resultDec % 9).ToString() + empty;
                    resultDec = resultDec / 9;
                }
                Console.WriteLine(empty);
            }

            else if (sing == "-")
            {
                BigInteger resultDec1 = sum + sum1;

                string empty1 = "";
                while (resultDec1 != 0)
                {
                    empty1 = (resultDec1 % 9).ToString() + empty1;
                    resultDec1 = resultDec1 / 9;
                }
                Console.WriteLine(empty1);
            }
        }
    }
}


