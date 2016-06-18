using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < n; i++)
            {
                
                if (firstArr[i] != int.Parse(Console.ReadLine()))
                {
                    Console.WriteLine("Not equal");
                    return;
                }
            }

            Console.WriteLine("Equal");
        }
    }
}
