using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Mutant_Squirrels
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            double t = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());

            double result = (t * b) * (s * n);
            
            if (result % 2 == 0)
            {
                result *= 376439;
                Console.WriteLine("{0:F3}",result);

            }
            else
            {
                result /= 7;
                Console.WriteLine("{0:F3}", result);
            }

        }
    }
}
