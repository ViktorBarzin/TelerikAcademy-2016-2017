using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            List<int> biggest = GetNBiggest(numbers, k);
            Console.WriteLine(biggest.Sum());
        }

        private static List<int> GetNBiggest(List<int> numbers, int n)
        {
            List<int> biggestNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                biggestNumbers.Add(numbers.Max());
                numbers.Remove(numbers.Max());
            }

            return biggestNumbers;
        }
    }
}
