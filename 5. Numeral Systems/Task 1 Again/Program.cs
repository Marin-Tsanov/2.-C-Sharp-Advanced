using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_1_Again
{
    class Program
    {
        static void Main()
        {

            BigInteger sum = 0;
            int n = 26;

            char[] a = Console.ReadLine().ToCharArray();
            foreach (char digita in a)
            {
                sum = (digita - 'a') + sum * n;
            }
            //Console.WriteLine(sum);

            string sing = Console.ReadLine();

            BigInteger sum1 = 0;
            int m = 7;

            char[] b = Console.ReadLine().ToCharArray();
            foreach (char digitb in b)
            {
                sum1 = (digitb - '0') + sum1 * m;
            }
            //Console.WriteLine(sum1);

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
                BigInteger resultDec1 = sum - sum1;

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

