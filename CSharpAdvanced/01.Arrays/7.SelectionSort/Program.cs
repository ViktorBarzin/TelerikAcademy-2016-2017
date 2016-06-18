using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SelectionSort
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

            SelectionSort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        private static void SelectionSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int min = numbers[i];
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                    }
                }
                Swap(ref numbers, numbers.IndexOf(min), i);
            }
        }

        private static void Swap(ref List<int> numbers, int indexA, int indexB)
        {
            int temp = numbers[indexA];
            numbers[indexA] = numbers[indexB];
            numbers[indexB] = temp;
        }
    }
}
