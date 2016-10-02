using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Binary_to_hexadecimal
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            if ((number.Length % 4)!= 0)
            {
            int missing0 = number.Length % 4;
            number = number.PadLeft((number.Length + (4 - missing0)), '0');
            }
            ////string number1 = BinaryToHex(number);
            //Console.WriteLine(number1.TrimStart('0'));

            string[] number1 = new string[number.Length / 4];

            for (int i = 0; i <number.Length/4 ; i++)
            {
                for (int j = 4*i; j <= 4*i; j++)
                {
                    number1[i] = string.Concat(number[j], number[j + 1], number[j + 2], number[j + 3]);
                }
            }

            //for (int i = 0; i < number.Length/4; i++)
            //{
            //    Console.WriteLine(number1[i]);
            //}

            string number2 = string.Join("", number1);
            Console.WriteLine(BinaryToHex(number2));
        }

        static Dictionary<string,string> HexBin = new Dictionary<string, string>()
        {
            { "0000","0" },
            { "0001","1" },
            { "0010","2" },
            { "0011","3" },
            { "0100","4" },
            { "0101","5" },
            { "0110","6" },
            { "0111","7" },
            { "1000","8" },
            { "1001","9" },
            { "1010","A" },
            { "1011","B" },
            { "1100","C" },
            { "1101","D" },
            { "1110","E" },
            { "1111","F" },
        };

        static string BinaryToHex(string hex)
        {

            //for (int i = 3; i < hex.Length; i+=4)
            //{
            //    s
            //}

            string result = "";
            foreach (string hexdigit in hex)
            {
                result += HexBin[hex];
            }
            return result;
        }


    }
}
