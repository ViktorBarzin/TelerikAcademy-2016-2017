using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(SumOfArrays(firstArr, secondArr));
        }

        private static string SumOfArrays(IList<int> firstArr, IList<int> secondArr)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < firstArr.Count; i++)
            {
                if (i + 1 < firstArr.Count)
                {
                    result.Append((firstArr[i] + secondArr[i]) + " ");
                }
                else
                {
                    result.Append(firstArr[i] + secondArr[i]);
                }
            }

            return result.ToString();
        }
    }
}
