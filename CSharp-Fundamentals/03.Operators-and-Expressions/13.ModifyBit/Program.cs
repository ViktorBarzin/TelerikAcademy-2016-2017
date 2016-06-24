using System;
namespace _13.ModifyBit
{
    class Program
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[] newBit = Console.ReadLine().ToCharArray();

            string asBits = Convert.ToString(number, 2);
            asBits = asBits.PadLeft(n + 1, '0');
            
            char[] asBitsChar = asBits.ToCharArray();

            asBitsChar[asBitsChar.Length - (n + 1)] = newBit[0];

            Console.WriteLine(Convert.ToInt64(string.Join("", asBitsChar), 2));
        }
    }
}