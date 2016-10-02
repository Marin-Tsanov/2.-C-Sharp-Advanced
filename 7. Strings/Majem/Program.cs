using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majem
{
    class Program
    {
        static void Main()
        {
            var sentence = "Shte hodime na kafe sled lekciq";
            Console.WriteLine(sentence);

            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(i);
            }
            var piece = sentence.Substring(5,10-5);

            Console.WriteLine(piece);
        }
    }
}
