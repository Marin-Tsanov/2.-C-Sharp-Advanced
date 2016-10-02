using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _6.Using_Classes_and_Objects
{
    class Program
    {
        static void Main()
        {
            StringBuilder password = new StringBuilder();

            // 3 special
            // 2 capital
            // 3 digits
            // 1 lower

            string capital = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
            string lower = capital.ToLower();
            string digits = "0123456789";
            string special = "<>?:][-+!~@#";

            Random rng = new Random();

            for (int i = 0; i < 3; i++)
            {
                password.Append(special[rng.Next(0, special.Length)]);
            }
            
            for (int i = 0; i < 2; i++)
            {
                int insertPosition = rng.Next(0, password.Length + 1);
                char capitalChar = capital[rng.Next(0, capital.Length)];
                password.Insert(insertPosition,capitalChar);
            }

            for (int i = 0; i < 3; i++)
            {
                int insertPosition = rng.Next(0, password.Length+1);
                char digit = digits[rng.Next(0, digits.Length)];
                password.Insert(insertPosition, digit);
            }

            int lowerCount = rng.Next(1, 7);

            for (int i = 0; i < lowerCount; i++)
            {
                int insertPosition = rng.Next(0, password.Length + 1);
                char lowerChar = lower[rng.Next(0, lower.Length + 1)];
                password.Insert(insertPosition, lowerChar); 
            }

            Console.WriteLine(password);
        }
    }
}
