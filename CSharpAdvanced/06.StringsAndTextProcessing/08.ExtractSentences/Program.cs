using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : 40/100 fix
            string wordToSearch = Console.ReadLine();
            string input = Console.ReadLine();

            Console.WriteLine(Extract(input,wordToSearch));
        }

        public static string Extract(string str, string keyword)
        {
            string[] arr = str.Split('.');
            string answer = string.Empty;

            foreach (string sentence in arr)
            {
                //Add any other required punctuation characters for splitting words in the sentence
                string[] words = sentence.Split(new char[] { ' ', ',','\\','\n','\t',':',';','@','!','?' });
                if (words.Contains(keyword))
                {
                    answer += sentence + ".";
                }
            }

            return answer;
        }
    }
}
