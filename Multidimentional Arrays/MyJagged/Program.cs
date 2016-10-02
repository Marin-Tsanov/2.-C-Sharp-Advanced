using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class program
    {
        static void Main()
        {
            int[] arr = new int[] { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            int counter0 = 0;
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    counter0++;
                }
                else if (arr[i] % 3 == 1)
                {
                    counter1++;
                }
                else if (arr[i] % 3 == 2)
                {
                    counter2++;
                }
            }

            int[][] arrjagged = new int[3][];
            arrjagged[0] = new int[counter0];
            arrjagged[1] = new int[counter1];
            arrjagged[2] = new int[counter2];

            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arrjagged[0][counter3] = arr[i];
                    counter3++;
                }
                else if (arr[i] % 3 == 1)
                {
                    arrjagged[1][counter4] = arr[i];
                    counter4++;
                }
                else if (arr[i] % 3 == 2)
                {
                    arrjagged[2][counter5] = arr[i];
                    counter5++;
                }
            }

            for (int row = 0; row < arrjagged.GetLength(0); row++)
            {
                foreach (var arrj in arrjagged[row])
                {
                    Console.Write(arrj + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
