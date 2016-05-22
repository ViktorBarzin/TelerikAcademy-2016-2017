using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IncreasingAbsoluteDifferences
{
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GetBiggestSequenceOfAbs(n);
        }

        private static void GetBiggestSequenceOfAbs(int numberOfSequences)
        {
            for (int i = 0; i < numberOfSequences; i++)
            {
                List<double> sequence = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                List<double> absoluteDifferences = new List<double>();

                for (int j = 0; j < sequence.Count - 1; j++)
                {
                    absoluteDifferences.Add(Math.Abs(sequence[j] - sequence[j+1]));
                }

                Console.WriteLine(IsNonDecreasing(absoluteDifferences));
            }
        }

        private static bool IsNonDecreasing(IList<double> numbers)
        {
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] > numbers[i+1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
