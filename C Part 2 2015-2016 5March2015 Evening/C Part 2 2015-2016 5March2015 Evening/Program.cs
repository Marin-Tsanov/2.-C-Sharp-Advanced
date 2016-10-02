using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_Problem
{
    class Program
    {
        static void Main()
        {
            string firstInput = Console.ReadLine();
            string[] input = firstInput.Split(' ');/*(Console.ReadLine()).Split(' ');*/

            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char[] a = input[i].ToCharArray();
                Array.Reverse(a);

                for (int j = 0; j < a.Length; j++)
                {
                    sum += (a[j] - 'a') * (Math.Pow(23, j));
                }
            }
            double sum2 = sum;
            int sum1 = 0;
            string empty = "";
            while (sum != 0)
            {
                sum1 = (int)sum % 23 + 97;
                empty = (Convert.ToChar(sum1)).ToString() + empty;
                sum = (int)sum / 23;
            }


            Console.WriteLine("{0} = {1}", empty, sum2);
        }
    }
}