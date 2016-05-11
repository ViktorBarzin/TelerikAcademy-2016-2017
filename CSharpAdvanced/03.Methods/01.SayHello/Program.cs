using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHello
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
           Hello(Console.ReadLine());
        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
