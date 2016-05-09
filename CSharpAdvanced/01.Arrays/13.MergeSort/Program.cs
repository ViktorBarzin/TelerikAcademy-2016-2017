using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
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

            numbers.Sort();
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
