using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(GetMaxSubSum(numbers));
        }

        private static int GetMaxSubSum(List<int> numbers)
        {
            int maxSoFar = 0, maxEndingHere = 0;

            foreach (int t in numbers)
            {
                maxEndingHere+= t;
                if (maxEndingHere < 0)
                    maxEndingHere = 0;
                if (maxSoFar < maxEndingHere)
                    maxSoFar = maxEndingHere;
            }


            return Math.Max(maxSoFar, maxEndingHere);
        }
    }
}
