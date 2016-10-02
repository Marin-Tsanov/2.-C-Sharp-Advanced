using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sum_integers
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            long sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
