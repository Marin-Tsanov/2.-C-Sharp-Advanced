using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    class Program
    {
        //static void FirstLoop(int number)
        //{
        //    for (int i = 1; i <= number; i++)
        //    {
        //        for (int j = 1; j <= i ; j++)
        //        {
        //            Console.Write("{0} ", j);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void SecondLoop(int part)
        //{
        //    for (int i = part-1; i >= 1; i--)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write("{0} ", j);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());

        //    FirstLoop(n);
        //    SecondLoop(n);
        //}

        static void Printline(int start, int end)
        {
            for (int j = start; j <= end; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int number)
        {
            for (int i = 1; i <=number; i++)
            {
                Printline(1, i);
            }

            for (int i = number-1; i >= 1; i--)
            {
                Printline(1, i);
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
    }
}
