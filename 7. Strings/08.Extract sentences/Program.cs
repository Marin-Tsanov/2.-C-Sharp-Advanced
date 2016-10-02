using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extract_sentences
{
    class Program
    {
        static string Extract(string[] text,string word)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int index = text[i].IndexOf(word, StringComparison.InvariantCultureIgnoreCase);

                while (index != -1)
                {
                    //int a = index + word.Length - 1;
                    //int b = text[i].Length-1;
                    //Console.WriteLine("{0} {1}", a,b);
                    //Console.WriteLine(text[i]);


                    if (index == 0 && index + word.Length - 1 != text[i].Length-1)
                    {
                        if (Char.IsLetter((char)text[i][index + word.Length]) == false)
                        {
                            builder.Append(text[i]);
                            builder.Append('.');
                            break;
                        }
                    }

                    else if (index == 0 && index + word.Length - 1 == text[i].Length-1)
                    {
                        builder.Append(text[i]);
                        builder.Append('.');
                        break;
                    }

                    else if (index!=0 && index + word.Length - 1 == text[i].Length-1)
                    {
                        if (Char.IsLetter((char)text[i][index - 1]) == false)
                        {
                            builder.Append(text[i]);
                            builder.Append('.');
                            break;
                        }
                    }
  
                    else if(index != 0 && index + word.Length - 1 != text[i].Length - 1)
                    {
                        if (Char.IsLetter((char)text[i][index - 1]) == false &&
                        Char.IsLetter((char)text[i][index + word.Length]) == false)
                        {
                            builder.Append(text[i]);
                            builder.Append('.');
                            break;
                        }
                    }
                    index = text[i].IndexOf(word, index + 1,StringComparison.InvariantCultureIgnoreCase);
                }
            }
            string result = builder.ToString();
            return result;
        }

        static void Main()
        {
            string word = "in";/*Console.ReadLine();*/
            string[] text = " We make . We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".Split('.');/*Console.ReadLine();*/
            string result = Extract(text, word);
            Console.WriteLine(result); 
            
        }
    }
}
