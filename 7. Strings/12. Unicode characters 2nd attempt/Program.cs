using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Unicode_characters_2nd_attempt
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            byte[] stringBytes = Encoding.Unicode.GetBytes(inputString);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder builder = new StringBuilder();
            Array.ForEach<char>(stringChars, c => builder.AppendFormat("\\u{0:X4}", (int)c));
            Console.WriteLine(builder);

        }
    }
}
