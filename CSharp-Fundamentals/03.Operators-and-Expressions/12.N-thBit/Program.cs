using System;
namespace _12.N_thBit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string asBits = Convert.ToString(number, 2);

            asBits = asBits.PadLeft(n, '0');
            Console.WriteLine("{0}", asBits[asBits.Length - n]);
        }
    }
}
    