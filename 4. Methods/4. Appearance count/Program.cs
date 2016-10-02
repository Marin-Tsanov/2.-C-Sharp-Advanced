using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Appearance_count
{
    class Program
    {
        static void Appear(int[] elements, int a)
        {
            int count = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i]== a )
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
            int x = int.Parse(Console.ReadLine());

            Appear(array,x);
        }
    }
}
