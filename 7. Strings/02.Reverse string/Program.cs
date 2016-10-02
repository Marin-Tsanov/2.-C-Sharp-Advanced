using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_string
{
    class Program
    {
        static string Reverse(string input)
        {
            StringBuilder reverse = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse.Append(input[i]);
            }
            return reverse.ToString();
        }

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Reverse(input));

        }
    }
}
