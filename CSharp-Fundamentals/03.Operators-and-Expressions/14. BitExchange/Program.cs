using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string inputBinary = Convert.ToString(input, 2);

            Console.WriteLine(inputBinary);
            for (int i = 3; i < 6; i++)
            {
                int lowerBit = GetBitAt(i, input);
                int higherBit = GetBitAt(i + 21, input);
                if (lowerBit == 0)
                {
                    input = SetZero(i + 21, input);
                }
                else
                {
                    input = SetOne(i + 21, input);
                }

                if (higherBit == 0)
                {
                    input = SetZero(i, input);
                }
                else
                {
                    input = SetOne(i, input);
                }
            }

            Console.WriteLine(input);
        }

        private static int GetBitAt(int position, int number)
        {        
            int mask = 1 << position;     
            int nAndMask = number & mask;
            int bit = nAndMask >> position;
            return bit;
        }

        private static int SetZero(int position, int number)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            return result;
        }

        private static int SetOne(int position, int number)
        {
            int mask = 1 << position;   
            int result = number | mask;
            return result;
        }
    }
}
