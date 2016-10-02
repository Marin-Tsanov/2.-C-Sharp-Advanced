using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _4.Hexadecimal_to_decimal
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(empty(number));
        }

        static string empty(string empty)
        {
            BigInteger sum = 0;
            for (int i = empty.Length -1; i >=0; i--)
            {
                if (char.IsDigit(empty[i]))
                {
                    sum += ((empty[i]-'0')*(BigInteger)(Math.Pow(16, (empty.Length - 1 - i))));
                }
                else
                {
                    sum+= ((empty[i] - 'A'+10) * (BigInteger)(Math.Pow(16, (empty.Length - 1 - i))));
                }
            }
            return empty=sum.ToString();
        }
    }
}
