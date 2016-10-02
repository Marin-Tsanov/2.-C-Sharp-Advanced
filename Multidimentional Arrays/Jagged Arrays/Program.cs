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
            int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int remainder = number % 3;
                sizes[remainder]++;
            }
            int[] offsets = new int[3];

            int[][] numbersByRemainder = new int[3][] {
  new int[sizes[0]], new int[sizes[1]],
  new int[sizes[2]] };
            foreach (var number in numbers)
            {
                int remainder = number % 3;
                int index = offsets[remainder];
                numbersByRemainder[remainder][index] = number;
                offsets[remainder]++;
            }

        }
    }
}
