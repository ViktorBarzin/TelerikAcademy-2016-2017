using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.NFactorial
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(n));
        }

        private static BigInteger CalculateFactorial(BigInteger n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }
}
