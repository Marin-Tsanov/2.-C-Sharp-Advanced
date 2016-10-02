using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3._1_Methods
{
    class Program
    {
       
        static void PrintLogo(string companyName)
        {
            Console.Write(companyName);
            Console.WriteLine("Tsanov");
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("positive");
            }
            else if (number<0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }


        static void PrintMax(float number1, float number2)
        {
            float max = Math.Max(number1,number2);

            //if (number2 > number1)  
            //{
            //    max = number2;
            //}

            Console.WriteLine(max);
        }

        static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());


            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());

            PrintSign(n);
            PrintSign(m);
            PrintMax(n, m);
        }

    }
}
