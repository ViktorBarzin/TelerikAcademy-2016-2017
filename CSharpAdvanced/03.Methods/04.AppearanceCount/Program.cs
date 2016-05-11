using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(CountNInCOllection(x,numbers));
        }

        private static int CountNInCOllection<T>(T search, IEnumerable<T> collection)
            where T : IComparable
        {
            return collection.Count(number => number.CompareTo(search) == 0);
        }
    }
}
