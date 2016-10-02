using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Integer_calculations
{
    class Program
    {
        static void Min(double[] elements)
        {
            double min = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (min>elements[i])
                {
                    min = elements[i];
                }
            }
            Console.WriteLine(min);
        }
        static void Max(double[] elements)
        {
            double max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (max < elements[i])
                {
                    max = elements[i];
                }
            }
            Console.WriteLine(max);
        }
        static void AverageSumProduct(double[] elements)
        {
            double average;
            double sum = 0;
            double product = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
                product *= (double)elements[i];
            }
            average = sum /(double) elements.Length;

            Console.WriteLine("{0:F2}",average);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
        static void Main()
        {
            double[] array1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Min(array1);
            Max(array1);
            AverageSumProduct(array1);
        }
    }
}
