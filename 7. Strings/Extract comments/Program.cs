using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_comments
{
    class Program
    {
        static List<int> FindDoubleSlashCommentStart(string code, string word)
        {
            var indices = new List<int>();

            int nextCommentStart = code.IndexOf(word);
            int nextNewLineIndex = 0;

            while (nextNewLineIndex != -1 && nextCommentStart != -1)
            {
                indices.Add(nextCommentStart);
                nextNewLineIndex = code.IndexOf(Environment.NewLine, nextCommentStart);
                indices.Add(nextNewLineIndex);
                nextCommentStart = code.IndexOf(word, nextNewLineIndex + 1);
            }
            return indices;

        }

        static string ExtractComments(string code)
        {
            var result = new StringBuilder();

            bool isInSingleLineComment = false;
            bool isInMultilineComment = false;
            char last = ' ';

            foreach (char symbol in code)
            {
                if (isInSingleLineComment || isInMultilineComment)
                {
                    result.Append(symbol);
                }

                if (last == '/' && symbol == '/' && !isInMultilineComment)
                {
                    result.Append("//");
                    isInSingleLineComment = true;
                }


                if (last == '/' && symbol == '*' && !isInSingleLineComment)
                {
                    result.Append("/*");
                    isInMultilineComment = true;
                }

                if (last =='\r' && symbol=='\n')
                {
                    if (isInSingleLineComment || isInMultilineComment)
                    {
                        result.Append("\r\n");
                    }
                    isInSingleLineComment = false;
                }

                if (last == '*' && symbol == '/')
                {
                    result.Append("\r\n");
                    isInMultilineComment = false;
                }

                last = symbol;
            }
            return result.ToString();
        }


        static void Main()
        {
            var code = @"/* just a meaningless comment */
namespace ExtractComments
{
    // my usings are here
    using System;

    // penka e //yaka macka
    class Startup
    {
        // otivam na kafe s ivan
        static void Main()
        {
            var code = ""; /* koito go e pisal tozi kod,
             sdflkjdsjfldsfjlkdsfjdslkfjdlkf
             ne e dobre */
        }
        // javascript
    }
}
// za cvqt
";
            //var indices = FindDoubleSlashCommentStart(code, "//");

            //for (int i = 0; i < indices.Count; i += 2)
            //{
            //    int start = indices[i];
            //    int end = indices[i + 1];
            //    var comment = code.Substring(start, end - start);

                //Console.WriteLine(comment);

                Console.WriteLine();


                Console.WriteLine(ExtractComments(code));
            }

            //Console.WriteLine(string.Join(", ",indices));

        }
    }

