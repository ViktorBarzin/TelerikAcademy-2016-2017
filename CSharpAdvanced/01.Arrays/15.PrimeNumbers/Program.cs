using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetBiggestPrime(n));

        }

        private static int GetBiggestPrime(int n)
        {
            for (int i = n; i >= 0 ; i--)
            {
                if (IsPrime(i))
                {
                    return i;
                }
            }

            return 2;
        }

        private static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
