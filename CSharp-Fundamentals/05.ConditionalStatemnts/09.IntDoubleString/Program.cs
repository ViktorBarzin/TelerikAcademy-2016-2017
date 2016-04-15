using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string varType = Console.ReadLine();
            string word = Console.ReadLine();

            if (varType == "text")
            {
                Console.WriteLine("{0}*",word);
            }
            else if (varType == "real")
            {
                double number = double.Parse(word);
                Console.WriteLine("{0:F2}",number + 1);
            }
            else
            {
                double number = double.Parse(word);
                Console.WriteLine(number + 1);
            }
        }
    }
}
