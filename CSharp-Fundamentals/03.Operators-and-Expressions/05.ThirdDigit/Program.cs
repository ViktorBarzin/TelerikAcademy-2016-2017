using System;
namespace _05.ThirdDigit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = (number / 100) % 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}",thirdDigit);
            }
        }
    }
}
