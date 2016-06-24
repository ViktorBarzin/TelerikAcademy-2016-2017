using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
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

            int currentSeq = 1;
            int maxSeq = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int k = i;
                while (k < n-1 && numbers[k] <= numbers[k + 1])
                {
                    currentSeq++;
                    k++;
                }

                if (currentSeq > maxSeq)
                {
                    maxSeq = currentSeq;
                }
                currentSeq = 1;
            }

            Console.WriteLine(maxSeq);
        }
    }
}
