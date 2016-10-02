using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static void Factorial(int n)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);

        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Factorial(n);
        }
    }
}
