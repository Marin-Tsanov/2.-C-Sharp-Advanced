using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static int Correct(string input)
        {
            int counter = 0;

            char[] work = input.ToCharArray();

            foreach (char element in work)
            {
                if (element == '(')
                {
                    ++counter;
                }
                else if (element == ')')
                {
                    --counter;
                }

            }

            return counter;
        }

        static void Main()
        {
            string input = ")(a+b))";
            int result = Correct(input);
            if (result == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}

