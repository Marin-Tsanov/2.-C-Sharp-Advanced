using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08_Extract_Sentence_2
{
    class Program
    {
        static string Extract(string word, string[] text)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                bool contains = Regex.IsMatch(text[i], string.Format(@"\b{0}\b", Regex.Escape(word)), RegexOptions.IgnoreCase);
                if (contains)
                {
                    builder.Append(text[i]);
                    builder.Append('.');
                }
            }

            var result = builder.ToString();
            return result;
        }

        static void Main()
        {
            string word = "in";/*Console.ReadLine();*/
            string[] text = "We are living in a yellow submarine . We will move out of it in 5 days.".Split('.');/*Console.ReadLine();*/
            string result = Extract(word, text);
            Console.WriteLine(result);
        }
    }
}
