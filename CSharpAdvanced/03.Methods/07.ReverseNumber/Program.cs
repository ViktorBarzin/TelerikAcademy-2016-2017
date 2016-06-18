using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(n));
        }

        private static decimal Reverse<T>(T n)
        {
            // Dont do this at home
           return decimal.Parse(string.Join("", n.ToString().Reverse()));
        }
    }
}
