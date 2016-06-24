using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
            string input = Console.ReadLine();
            Console.WriteLine(ParseUpcaseTags(input,"<upcase>","</upcase>"));
        }

        private static string ParseUpcaseTags(string input,string openTag,string closeTag)
        {
            StringBuilder parsedText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i + openTag.Length < input.Length && input.Substring(i, openTag.Length).Equals(openTag))
                {
                    string textToAdd = input.Substring(
                        i + openTag.Length,
                        input.IndexOf(closeTag, i + openTag.Length) - i - closeTag.Length + 1);
                    parsedText.Append(textToAdd.ToUpper());
                    i = input.IndexOf(closeTag, i + openTag.Length) + closeTag.Length - 1;
                }
                else
                {
                    parsedText.Append(input[i]);
                }
            }

           return parsedText.ToString();
        }
    }
}
