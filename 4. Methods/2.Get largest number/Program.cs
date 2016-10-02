using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Get_largest_number
{
    class Program
    {

        static void GetMax(long a, long b)
        {
            long d = (Math.Max(a, b));
            Console.WriteLine(d);
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            long[] array = new long[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            //int[] array = {7, 19, 19};

            long c = Math.Max(array[0], array[1]);

            GetMax(c, array[2]);

        }
    }
}
