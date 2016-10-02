using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.nu

namespace _1
{
    class Program
    {
        static void Main()
        {
            char[] a = Console.ReadLine().ToCharArray();

            Array.Reverse(a);

             sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum+ (a[i] - 'a') * (Math.Pow(23, i));
            }
            Console.WriteLine(sum);
        }
    }
}
