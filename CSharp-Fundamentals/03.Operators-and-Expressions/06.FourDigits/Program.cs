using System;
namespace _06.FourDigits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numberAsString = number.ToString();
            int a = numberAsString[0] - '0';
            int b = numberAsString[1] - '0';
            int c = numberAsString[2] - '0';
            int d = numberAsString[3] - '0';

            Console.WriteLine(a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
