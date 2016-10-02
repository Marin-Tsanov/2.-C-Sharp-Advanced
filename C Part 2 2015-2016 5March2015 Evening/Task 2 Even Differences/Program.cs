using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Even_Differences
{
    class Program
    {
        static void Main()
        {
            long[] array = Console.ReadLine().Split(' ')
                                            .Select(long.Parse)
                                            .ToArray();

            long m = 0;
            long n = 1;

            for (long i = 1; i < array.Length; i++)
            {
                if (n == i)
                {
                    long p = 0;

                    if (array[i] > array[i - 1])
                    {
                        p = array[i] - array[i - 1];
                    }
                    else
                    {
                        p = array[i - 1] - array[i];
                    }

                    if (p % 2 == 0)
                    {
                        m += p;
                        n = i + 2;
                        if (n > array.Length - 1)
                        {
                            break;
                        }
                    }
                    else
                    {
                        n = i + 1;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("{0}", m);
        }
    }
}