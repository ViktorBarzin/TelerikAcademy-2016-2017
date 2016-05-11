using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // When speaking about writing everything on 1 line...
            Console.WriteLine(SwitchDigit(GetLastDigit(int.Parse(Console.ReadLine()))));
        }

        private static int GetLastDigit<T>(T number)
        {
            return byte.Parse(number.ToString()[number.ToString().Length - 1].ToString());
        }

        private static string SwitchDigit(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Invalid digit";
            }
        }
    }
}
