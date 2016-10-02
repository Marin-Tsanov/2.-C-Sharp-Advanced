using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static int Substring(string input, string pattern)
        {
            int open = input.IndexOf(pattern);
            int counter = 0;

            while (open != -1)
            {
                if (open > 0)
                {
                    counter++;
                }

                open = input.IndexOf(pattern, open + 1);
            }
            return counter;
        }


        static void Main()
        {
            string pattern = (Console.ReadLine()).ToLower();
            string input = (Console.ReadLine()).ToLower();

            int count = Substring(input, pattern);
            Console.WriteLine(count);
        }

    }
}

