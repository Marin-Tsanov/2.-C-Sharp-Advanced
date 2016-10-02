using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fill_the_Matrix
{
    class Program
    {
        static void Main()
        {
           
            int n = 4;
            char determine = 'c';
            int a = 0;
            int[,] matrix = new int[n, n];

            if (determine == 'a')
            {
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        a += 1;
                        matrix[row, col] = a;
                    }
                }

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }

            if (determine == 'b')
            {
                for (int col = 0; col < n; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            a += 1;
                            matrix[row, col] = a;
                        }
                    }
                    else
                    {
                        for (int row = n-1; row >=0; row--)
                        {
                            a += 1;
                            matrix[row, col] = a;
                        }
                    }

                }

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }

            if (determine == 'c')
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col <= row; col++)
                    {
                        a += 1;
                        matrix[row - col, col] = a;
                    }
                }



                for (int row = n-1; row >=1; row--)
                {
                    for (int col = 1; col <=row; col++)
                    {
                        a += 1;
                        matrix[row-col+1, col] = a;
                    }

                }

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write("{0} ", matrix[row, col]);
                        
                    }
                    Console.WriteLine();
                }
            }



        }

    }
}
