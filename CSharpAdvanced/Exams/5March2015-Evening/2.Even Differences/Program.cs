using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Even_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < numbers.Count(); i++)
            {
                if (Math.Abs(numbers[i] - numbers[i-1]) % 2 == 0)
                {
                    
                }
            }
        }
    }
}
