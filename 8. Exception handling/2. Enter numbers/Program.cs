using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Enter_numbers
{
    class Program
    {
        static void ReadNumber(int start, int end)
        {

        }

        static void Main()
        {
            ReadNumber

            try
            {
                int[] array = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Exception");
            }

            catch()
            {

            }
        }
    }
}
