namespace _1.De_catCoding
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', };

            foreach (var command in input.Split(' '))
            {
                ulong value = StringToInt(command);
                result.Append(IntToStringFast(value, letters)).Append(" ");
            }
            Console.WriteLine(result.ToString().ToLower());
        }

        public static string IntToString(int value, char[] baseChars)
        {
            string result = string.Empty;
            int targetBase = baseChars.Length;

            do
            {
                result = baseChars[(int)value % targetBase] + result;
                value = value / targetBase;
            }
            while (value > 0);

            return result;
        }

        public static ulong StringToInt(string input)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTU";

            int cbase = 21;
            ulong results = 0;
            foreach (char digit in input.ToUpper().ToArray())
            {
                results = ((ulong)cbase * results) + (ulong)characters.ToUpper().IndexOf(digit);
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
    }
}
