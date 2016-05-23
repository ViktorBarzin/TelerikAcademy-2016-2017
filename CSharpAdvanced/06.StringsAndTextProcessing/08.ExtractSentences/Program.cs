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
            // TODO : 90/100 fix
            string wordToSearch = Console.ReadLine().ToLower();
            string input = Console.ReadLine();

            Console.WriteLine(Extract(input, wordToSearch));
        }

        public static string Extract(string str, string keyword)
        {
            string[] arr = str.Split('.');
            StringBuilder answer = new StringBuilder();
            char[] separators = GetSeparators(str);
            foreach (string sentence in from sentence in arr let words = sentence.ToLower().Split(separators).ToArray() let isMatch = words.Any(x => x == keyword) where isMatch select sentence)
            {
                answer.Append(sentence + ".");
            }

            return answer.ToString();
        }

        private static char[] GetSeparators(string text)
        {
            return text.Where(x => !char.IsLetter(x) && x != '.').Distinct().ToArray();
        }
    }
}
