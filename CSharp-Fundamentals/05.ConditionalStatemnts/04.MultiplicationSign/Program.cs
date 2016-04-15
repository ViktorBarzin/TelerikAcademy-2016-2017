using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double result = a * b * c;
            if (result < 0)
            {
                Console.WriteLine("-");
            }
            else if (result > 0)
            {
                Console.WriteLine("+");
            }
            else if (result == 0)
            {
                Console.WriteLine("0");
            }

        }

    }
}