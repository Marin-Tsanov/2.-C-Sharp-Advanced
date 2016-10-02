using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sorting_array
{
    class Program
    {
        static void Max(int[] elements, int m)
        {

            for (int i = m - 1; i >= 1; i--)
            {
                //Console.WriteLine(elements[i]);
                for (int j = i - 1; j >= 0; j--)
                {
                    if (elements[i] < elements[j])
                    {
                        int temp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = temp;

                        //foreach (int element in elements)
                        //{
                        //    Console.Write("{0} ", element);
                        //}
                        //Console.WriteLine();
                    }
                }

            }
            foreach (int element in elements)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //int n = 4;
            //int[] array1 = new int [] { 5, 4, 3, 1 };

            Max(array1, n);

        }
    }
}
