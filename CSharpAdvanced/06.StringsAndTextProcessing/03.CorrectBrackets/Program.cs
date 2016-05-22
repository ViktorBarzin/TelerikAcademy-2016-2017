using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int openingBraces = 0;
            int closingBraces = 0;

            foreach (var letter in input)
            {
                if (letter == '(')
                {
                    openingBraces++;
                }
                else if (letter == ')')
                {
                    closingBraces++;
                }
            }
            Console.WriteLine(openingBraces == closingBraces ? "Correct" : "Incorrect");
        }
    }
}
