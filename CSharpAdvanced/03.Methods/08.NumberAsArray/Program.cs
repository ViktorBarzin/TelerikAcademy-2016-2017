using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] resultArray = new int[ArrayLength(input[0], input[1])];
            int length = ArrayLength(input[0], input[1]);
            var firstArrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondArrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", AddLists(firstArrayOfNumbers, secondArrayOfNumbers, length)));
        }

        public static int[] AddLists(List<int> firstArray, List<int> secondArray, int length)
        {
            //List<int> resultArray = new List<int>();
            var resultArray = new int[length];
            EqualizeLists(firstArray, secondArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                int sum = firstArray[i] + secondArray[i];
                if (sum >= 10)
                {
                    resultArray[i] = sum - 10;
                    if (i < length - 1)
                    {
                        firstArray[i + 1] += 1;
                    }
                }
                else
                {
                    resultArray[i] = sum;
                }
            }

            return resultArray;
        }

        static int ArrayLength(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        public static void EqualizeLists(List<int> firstArray, List<int> secondArray)
        {
            int firstListLength = firstArray.Count;
            int secondListLength = secondArray.Count;

            if (firstListLength > secondListLength)
            {
                int numbersToAdd = firstListLength - secondListLength;
                for (int i = 0; i < numbersToAdd; i++)
                {
                    secondArray.Add(0);
                }
            }
            else
            {
                int numbersToAdd = secondListLength - firstListLength;
                for (int i = 0; i < numbersToAdd; i++)
                {
                    firstArray.Add(0);
                }
            }
        }
    }
}
