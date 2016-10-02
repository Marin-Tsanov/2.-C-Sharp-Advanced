using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_sum
{
    class Program
    {
        static void Main()
        {
            int width = 3;
            int height = 2;

            int[,] matrix =
                {
  {0, 2, 4, 0, 9, 5},
  {7, 1, 3, 3, 2, 1},
  {1, 3, 9, 8, 5, 6},
  {4, 6, 7, 9, 1, 0}
                };

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - height + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
                {
                    int sum = 0;

                    for (int paltformRow = row; paltformRow < row + height; paltformRow++)
                    {
                        for (int platformCol = col; platformCol < col + width; platformCol++)
                        {
                            sum += matrix[paltformRow, platformCol];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;

                    }
                }
            }
            Console.WriteLine(bestSum);
            for (int i = bestRow; i < bestRow+height; i++)
            {
                for (int j = bestCol; j < bestCol+width; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
