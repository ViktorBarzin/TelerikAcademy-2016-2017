using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 5 == 0 && input % 7 == 0)
            {
                Console.WriteLine("true {0}", input);
            }
            else
            {
                Console.WriteLine("false {0}", input);
            }
        }
    }
}
