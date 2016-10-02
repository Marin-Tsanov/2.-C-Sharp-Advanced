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
            if ((number.Length % 4) != 0)
            {
                int missing0 = number.Length % 4;
                number = number.PadLeft((number.Length + (4 - missing0)), '0');
            }

            string[] number1 = new string[number.Length / 4];

            for (int i = 0; i < number.Length / 4; i++)
            {
                for (int j = 4 * i; j <= 4 * i; j++)
                {
                    number1[i] = string.Concat(number[j], number[j + 1], number[j + 2], number[j + 3]);
                }
            }

            string[] number2 = new string[number.Length / 4];

            for (int k = 0; k < number1.Length; k++)
            {

                if (number1[k] == "0001")
                {
                    number2[k] = "1";
                }

                else if (number1[k] == "0010")
                {
                    number2[k] = "2";
                }

                else if (number1[k] == "0011")
                {
                    number2[k] = "3";
                }
                else if (number1[k] == "0100")
                {
                    number2[k] = "4";
                }
                else if (number1[k] == "0101")
                {
                    number2[k] = "5";
                }
                else if (number1[k] == "0110")
                {
                    number2[k] = "6";
                }
                else if (number1[k] == "0111")
                {
                    number2[k] = "7";
                }
                else if (number1[k] == "1000")
                {
                    number2[k] = "8";
                }
                else if (number1[k] == "1001")
                {
                    number2[k] = "9";
                }
                else if (number1[k] == "1010")
                {
                    number2[k] = "A";
                }
                else if (number1[k] == "1011")
                {
                    number2[k] = "B";
                }
                else if (number1[k] == "1100")
                {
                    number2[k] = "C";
                }
                else if (number1[k] == "1101")
                {
                    number2[k] = "D";
                }
                else if (number1[k] == "1110")
                {
                    number2[k] = "E";
                }
                else if (number1[k] == "1111")
                {
                    number2[k] = "F";
                }
                else if (number1[k] == "0000")
                {
                    number2[k] = "0";
                }

            }
            for (int m = 0; m < number1.Length; m++)
            {
                Console.Write(number2[m]);
            }
        }
    }
}
