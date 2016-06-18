using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(GetMax(GetMax(input[0], input[1]),input[2]));
        }

        private static T GetMax<T>(T a, T b)
            where T:IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
