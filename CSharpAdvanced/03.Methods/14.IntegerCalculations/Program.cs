using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            // minimum, maximum, average, sum and product
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(GetMinimum(numbers));
            Console.WriteLine(GetMaximum(numbers));
            Console.WriteLine("{0:F2}", GetAverage(numbers));
            Console.WriteLine(GetSum(numbers));
            Console.WriteLine(GetProduct(numbers));

        }

        private static int GetMinimum(params int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        private static int GetMaximum(params int[] numbers)
        {
            int max = int.MinValue;
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static double GetAverage(params int[] numbers)
        {
            return (double)GetSum(numbers) / (double)numbers.Count();
        }

        private static int GetSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int t in numbers)
            {
                sum += t;
            }

            return sum;
        }

        private static BigInteger GetProduct(params int[] numbers)
        {
            return numbers.Aggregate<int, BigInteger>(1, (current, t) => current * (BigInteger)t);
        }
    }
}
