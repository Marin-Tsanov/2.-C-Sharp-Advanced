using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static bool Correct(string input, string word1, string word2)
        {
            bool result = true;

            int open = input.IndexOf(word1);
            List<int> openbracket = new List<int>();

            while (open != -1)
            {
                openbracket.Add(open);
                //Console.WriteLine(open);
                if (open==input.Length-1)
                {
                    break;
                }
                open = input.IndexOf(word1, open + 1);
            }

            int close = input.LastIndexOf(word2);
            List<int> closebracket = new List<int>();

            while (close != -1)
            {
                closebracket.Add(close);
                //Console.WriteLine(close);
                if (close == 0)
                {
                    break;
                }
                close = input.LastIndexOf(word2, close -1);
            }
            if (openbracket.Count == closebracket.Count)
            {
                for (int i = 0; i < openbracket.Count; i++)
                {
                    if (openbracket[i] > closebracket[i])
                    {
                        result = false;
                        break;
                    }
                }
            }

            else
            {
                result = false;
            }
            
            return result;
        }

        static void Main()
        {
            string input = ")((a+b)/5-d)";
            bool result = Correct(input, "(", ")");

            string answer = result ? answer = "Correct" : answer = "Incorrect";
            Console.WriteLine(answer);
        }
    }
}

