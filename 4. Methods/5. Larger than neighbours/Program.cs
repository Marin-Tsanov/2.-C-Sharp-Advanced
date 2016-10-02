using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Larger_than_neighbours
{
    class Program
    {
        static void Larger(int[] elements)
        {
            int count = 0;

            for (int i = 1; i < elements.Length -1; i++)
            {
                if ((elements[i] > elements[i-1]) &&
                    (elements[i] > elements[i + 1]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            Larger(array);
        }
    }
}
