using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static string Parse(string input, string word1, string word2)
        {
            List<int> Parse = new List<int>();

            int open = input.IndexOf(word1);
            int close = input.IndexOf(word2);

            while (open != -1 && close != -1)
            {
                if (open >= 0) // moje i bez if , raboti 
                {              // i bez tqh proverih 
                    Parse.Add(open);
                }
                if (close>0)
                {
                    Parse.Add(close);
                }

                open  = input.IndexOf(word1, open + 8);
                close = input.IndexOf(word2, close + 8);
            }
            
            for (int i = 1; i < Parse.Count; i += 2)
            {
                Parse[i] = Parse[i] + 9;
            }

            StringBuilder builder = new StringBuilder();

            builder.Append(input);
            
            for (int i = 0; i < Parse.Count; i += 2)
            {
                builder.Replace(input.Substring(Parse[i], Parse[i + 1] - Parse[i]),
                                input.Substring(Parse[i], Parse[i + 1] - Parse[i]).Replace("<upcase>", "").Replace("</upcase>", "").ToUpper());
            }

            string result = builder.ToString();
            return result;
        }


        static void Main()
        {

            string input = Console.ReadLine();
            string result = Parse(input, "<upcase>", "</upcase>");
            Console.WriteLine("{0}", result);

        }
    }
}