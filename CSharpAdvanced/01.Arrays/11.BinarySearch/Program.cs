using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
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

            int search = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(numbers, search, 0, numbers.Count));
        }

        private static int BinarySearch(List<int> numbers, int search, int l, int r)
        {
            if (l >= r)
            {
                return -1;
            }
            int middle = (l + r) / 2;
            if (search < numbers[middle])
            {
                return BinarySearch(numbers, search, l, middle);
            }
            if (search > numbers[middle])
            {
                return BinarySearch(numbers, search, middle + 1, r);
            }
            if (search == numbers[middle])
            {
                return middle;
            }
            return -1;
        }
    }
}
