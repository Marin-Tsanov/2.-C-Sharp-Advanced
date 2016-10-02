using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Execute(int value)
        {
            if (Enumerable.Range(2, 98).Contains(value) == false)
            {
                throw new Exception("Exception");
            }
        }

        static void Compare(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    continue;
                }
                else
                {
                    throw new Exception("Exception");
                }
            }
            Console.Write("1 < ");

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write("{0} < ", array[j]);
            }

            Console.Write("100");
        }
    
    static void Main()
    {
        try
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                Execute(array[i]);
            }

            Compare(array);

        }
        catch (FormatException)
        {
            Console.WriteLine("Exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
}
