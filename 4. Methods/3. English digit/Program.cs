using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.English_digit
{
    class Program
    {
        static void EnglishDigit(int a)
        {
            int b = a % 10;
            switch(b)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
            }
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number>=0)
            {
                EnglishDigit(number);
            }
            else
            {
                EnglishDigit(Math.Abs(number));
            }
        }
    }
}
