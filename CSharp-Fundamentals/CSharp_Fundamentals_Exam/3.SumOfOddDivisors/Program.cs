using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SumOfOddDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sumOfDivisors = 0;
            for (int i = a; i <= b; i++)
            {
                sumOfDivisors += GetSumOfDivisors(GetDivisors(i));
            }

            Console.WriteLine(sumOfDivisors);
        }
        private static List<int> GetDivisors(int n)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }

        private static int GetSumOfDivisors(List<int> divisors)
        {
            int sum = 0;
            for (int i = 0; i < divisors.Count; i++)
            {
                if (divisors[i] % 2 == 1)
                {
                    sum += divisors[i];
                }
            }

            return sum;
        }
    }
}
