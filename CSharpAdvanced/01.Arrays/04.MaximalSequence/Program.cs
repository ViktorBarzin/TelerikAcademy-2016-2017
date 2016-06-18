using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSeq = 1;
            int currentSeq = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    currentSeq++;
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                    }
                    currentSeq = 1;

                }
            }

            Console.WriteLine(Math.Max(currentSeq));
        }
    }
}
