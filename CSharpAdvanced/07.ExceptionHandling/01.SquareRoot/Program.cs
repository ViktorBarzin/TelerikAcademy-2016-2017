using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            TryGetSquareRoot(number);
        }

        private static void TryGetSquareRoot(string n)
        {
            try
            {
                double number = double.Parse(n);
                if (number < 0)
                {
                    throw new FormatException("Integer must not be negative");
                }
                double square = Math.Sqrt(number);
                Console.WriteLine("{0:F3}", Math.Round(square,3));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}