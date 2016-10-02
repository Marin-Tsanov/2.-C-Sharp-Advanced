using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Series_of_letters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            builder.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]==input[i-1])
                {
                    continue;
                }
                else
                {
                    builder.Append(input[i]);
                }
            }
            Console.WriteLine(builder.ToString());

        }
    }
}
