using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            numbers.Sort();

            int maxOccurences = 1;
            int maxNumber = numbers[0];
            
            for (int i = 0; i < numbers.Count-1; i++)
            {
                int current = 1;
                int j = i;
                while (j < numbers.Count-1 && numbers[j] == numbers[j+1])
                {
                    current++;
                    j++;
                }

                if (current > maxOccurences)
                {
                    maxOccurences = current;
                    maxNumber = numbers[i];
                }
            }

            Console.WriteLine("{0} ({1} times)",maxNumber,maxOccurences);
        }
    }
}
