using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            string[] reorderedList = new string[words.Count];
            for (int i = 0; i < words.Count; i++)
            {
                string temp = words[i];
                int index = temp.Length % n + 1 - 1;
                reorderedList[index]=words[i];
            }

            Console.WriteLine(string.Join(",",reorderedList));
        }
    }
}
