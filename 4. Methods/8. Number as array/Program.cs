using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Number_as_array
{
    class Program
    {
        static double Number(double[] elements)
        {
            double sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i] * (Math.Pow(10, i));
            }
            return sum;
        }
        
        static void Result(int f)
        {
            List<int> intList = new List<int>();

            do
            {
                int d = f % 10;
                f = f / 10;
                intList.Add(d);
            }
            while (f != 0);

            foreach (int element in intList)
            {
                Console.Write("{0} ", element);
            }
        }

        static void Main()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] array1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] array2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            double a = Number(array1);
            Console.WriteLine(a);
            double b = Number(array2);
            Console.WriteLine(b);
            int c = (int)(a + b);
            Console.WriteLine(c);
            Result(c);
        }
    }
}
