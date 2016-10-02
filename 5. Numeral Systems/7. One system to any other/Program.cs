using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _7.One_system_to_any_other
{
    class Program
    {
        static void Main()
        {
            BigInteger s = BigInteger.Parse(Console.ReadLine());
            char[] n = (Console.ReadLine()).ToCharArray();
            BigInteger d = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = 0;

            if (s == 16)
            {
                sum = HexToDec(n.ToString());
            }
            else
            {
                foreach (char digit in n)
                {
                    sum = (digit - '0') + sum * s;
                }
            }

            if (d == 16)
            {
                Console.WriteLine(DecToHex(sum).TrimStart('0'));
            }
            else
            {
                string empty = "";
                while (sum != 0)
                {
                    {
                        empty = (sum % d).ToString() + empty;
                        sum = sum / d;
                    }
                }
                Console.WriteLine(empty.TrimStart('0'));
            }
        }

        static BigInteger HexToDec(string empty)
        {
            BigInteger sum = 0;
            for (int i = empty.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(empty[i]))
                {
                    sum += ((empty[i] - '0') * (BigInteger)(Math.Pow(16, (empty.Length - 1 - i))));
                }
                else
                {
                    sum += ((empty[i] - 'A' + 10) * (BigInteger)(Math.Pow(16, (empty.Length - 1 - i))));
                }
            }
            return sum;
        }

        static string DecToHex(BigInteger n)
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
