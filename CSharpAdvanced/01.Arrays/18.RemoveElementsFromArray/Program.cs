using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveElementsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(n - GetLongestIncreasingSeq(numbers) + 1);
        }

        private static int GetLongestIncreasingSeq(List<int> numbers)
        {
            int max = 1;
            int current = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] <= numbers[i + 1])
                    {
                        current++;
                    }
                }
                if (current > max)
                {
                    max = current;
                }
                current = 0;
            }

            return Math.Max(max, current);
        }
    }
}
