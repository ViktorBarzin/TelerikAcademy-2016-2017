using System;
namespace _11._3rdBit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 8)
            {
                Console.WriteLine("0");
                return;
            }

            string bits = Convert.ToString(number, 2);
            Console.WriteLine("{0}", bits[bits.Length - 4]);
        }
    }
}