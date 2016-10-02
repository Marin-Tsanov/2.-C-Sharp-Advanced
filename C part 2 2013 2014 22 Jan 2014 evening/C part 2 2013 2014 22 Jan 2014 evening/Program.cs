using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_part_2_2013_2014_22_Jan_2014_evening
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[,] matrix = new long[n, n];

            for (int i = 0; i < n; i++)
            {
                var values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = long.Parse(values[j]);
                }

            }

            long sumMax = long.MinValue;
            
            if (n - 3 < 2)
            {
                long sumD = 0;

                for (int i = 0, j = 0; i < n; i++, j++)
                {
                    sumD += matrix[i, j];
                }

                Console.WriteLine("NO {0}", sumD);
            }

            else if (n - 3 >= 2)
            {
                for (int i = 0; i <= matrix.GetLength(0) - 3; i++)
                {
                    for (int j = 0; j <= matrix.GetLength(1) - 5; j++)
                    {
                        int k = 1;
                        int m = 1;
                        int o = 1;
                        int s= 2;

                        long sum = 0;
                        sum += matrix[i, j];
                        while (k != 7)
                        {
                            if (k <= 2)
                            {
                                if (matrix[i, j + k] - 1 == matrix[i, j + k - 1])
                                {
                                    sum += matrix[i, j + k];
                                    k++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else if (k <= 4)
                            {
                                if (matrix[i+m, j + s] - 1 == matrix[i+m-1, j + s])
                                {
                                    sum += matrix[i + m, j + s];
                                    m++;
                                    k++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            else if (k <= 6)
                            {
                                if (matrix[i+s, j + s + o] - 1 == matrix[i+s, j + s+o-1])
                                {
                                    sum += matrix[i + s, j + s + o];
                                    o++;
                                    k++;
                                }
                                else
                                {
                                    break;
                                }

                                if (k == 7)
                                {
                                    if (sum > sumMax)
                                    {
                                        sumMax = sum;
                                    }
                                }
                            }

                        }
                    }
                }
                if (sumMax > long.MinValue)
                {
                    Console.WriteLine("YES {0}", sumMax);
                }
                else
                {
                    long sumD = 0;

                    for (int i = 0, j = 0; i < n; i++, j++)
                    {
                        sumD += matrix[i, j];
                    }

                    Console.WriteLine("NO {0}", sumD);
                }
            }
        }
    }
}
