using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CalculationProblem
{
    class Program
    {
        private static ulong StringToInt(string input)
        {
            // Select base characters
            const string CHARACTERS = "abcdefghijklmnopqrstuvw";
            // Select base
            const int CBASE = 23;
            ulong results = 0;
            foreach (char digit in input.ToUpper().ToArray())
            {
                results = ((ulong)CBASE * results) + (ulong)CHARACTERS.ToUpper().IndexOf(digit);
            }

            return results;
        }

        public static string IntToStringFast(ulong value, char[] baseChars)
        {
            int i = 32;
            char[] buffer = new char[i];
            ulong targetBase = (ulong)baseChars.Length;

            do
            {
                buffer[--i] = baseChars[(value % targetBase)];
                value = value / targetBase;
            }
            while (value > 0);

            char[] result = new char[32 - i];
            Array.Copy(buffer, i, result, 0, 32 - i);

            return new string(result);
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            ulong sum = 0;
            foreach (string inCat in input)
            {
                sum += StringToInt(inCat);
            }

            Console.WriteLine("{0} = {1}",IntToStringFast(sum, new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w' }),sum);
        }
    }
}
