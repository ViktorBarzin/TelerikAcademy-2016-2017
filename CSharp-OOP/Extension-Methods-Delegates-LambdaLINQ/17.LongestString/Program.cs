using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfStrings = new List<string>() {"1", "12", "123", "1234"};
            string stringWithBiggestLenght = listOfStrings.FirstOrDefault(x => x.Length == listOfStrings.Max(y => y.Length));
            Console.WriteLine(stringWithBiggestLenght);
        }
    }
}
