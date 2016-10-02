using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _2.Binary_to_decimal
{
    class Program
    {
        static void Main()
        {
            char[] number = Console.ReadLine().ToCharArray();


            BigInteger sum = 0;
            for (int i = number.Length - 1; i >=0 ; i--)
            {
                if (number[i]=='0')
                {
                    continue;
                }
                else
                {
                    sum = sum + (BigInteger)Math.Pow(2, (number.Length - 1 - i));
                }
            }

            Console.WriteLine(sum);

        }
    }
}
