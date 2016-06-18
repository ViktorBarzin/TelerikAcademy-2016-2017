using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", 
                new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
                .Where(x => x % 3 == 0 && x % 7 == 0)
                .ToList()));
        }
    }
}
