using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            double[] numbers =
                Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(double.Parse)
                       .ToArray();

            Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }

        private static void Sort(IList<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Swap(numbers,i,numbers.IndexOf(GetMaxElementFromCollection(numbers, i, numbers.Count - 1)));
            }
        }

        private static double GetMaxElementFromCollection(IList<double> numbers, int startIndex, int endIndex)
        {
            double max = double.MinValue;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static void Swap(IList<double> numbers, int indexA, int indexB)
        {
            double temp = numbers[indexA];
            numbers[indexA] = numbers[indexB];
            numbers[indexB] = temp;
        }
    }
}
