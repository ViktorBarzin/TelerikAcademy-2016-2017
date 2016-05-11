using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    using System.CodeDom.Compiler;

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] numbers =
                Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToArray();

            Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }

        private static void Sort(IList<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                Swap(numbers,i,numbers.IndexOf(GetMaxElementFromCollection(numbers, i, numbers.Count - 1)));
            }
        }

        private static int GetMaxElementFromCollection(IList<int> numbers, int startIndex, int endIndex)
        {
            int max = int.MinValue;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static void Swap(IList<int> numbers, int indexA, int indexB)
        {
            int temp = numbers[indexA];
            numbers[indexA] = numbers[indexB];
            numbers[indexB] = temp;
        }
    }
}
