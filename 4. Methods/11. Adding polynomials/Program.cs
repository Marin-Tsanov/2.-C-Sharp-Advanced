using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program
    {
        static void Adding(int[] elements1,int[] elements2,int n)
        {
            int[] element = new int[n];

            for (int i = 0; i < n; i++)
            {
                element[i] = elements1[i] + elements2[i];
                Console.Write("{0} ",element[i]);
            } 
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Adding(array1, array2, n);
        }
    }
}
