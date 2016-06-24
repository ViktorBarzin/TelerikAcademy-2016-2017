using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(XToDecimal("1010",2));
            Console.WriteLine(DecimalToX(10,new []{'0','1'}));
        }

        public static ulong XToDecimal(string input,int baseSystem)
        {
            // string characters = "0123456789";
            StringBuilder characters = new StringBuilder();
            for (int i = 0; i < baseSystem; i++)
            {
                characters.Append(i);
            }

            int cbase = baseSystem;
            ulong results = 0;
            foreach (char digit in input.ToUpper().ToArray())
            {
                results = ((ulong)cbase * results) + (ulong)characters.ToString().ToUpper().IndexOf(digit);
            }

            return results;
        }

        public static string DecimalToX(ulong value, char[] baseChars)
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
    }
}
