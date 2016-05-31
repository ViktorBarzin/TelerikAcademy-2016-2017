using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Messages
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    class Program
    {
        /*
         * markoncykyanogi (56398)
-
         cykyan (39)
=
markoncykmaryan (56359)
         */

        private static Dictionary<string, int> georgeToIntDictionary = new Dictionary<string, int>
                                                                          {
            {"cad",0},
            {"xoz",1 },
            {"nop",2 },
            {"cyk",3 },
            {"min",4 },
            {"mar",5 },
            {"kon",6 },
            {"iva",7 },
            {"ogi",8 },
            {"yan",9 }
                                                                          };
        private static Dictionary<int, string> intToGeorgeDictionary = new Dictionary<int, string>
                                                                          {
            {0,"cad"},
            {1,"xoz" },
            {2,"nop" },
            {3,"cyk" },
            {4,"min" },
            {5,"mar" },
            {6,"kon" },
            {7,"iva" },
            {8,"ogi" },
            {9,"yan" }
                                                                          };
        // TODO : integer type
        static void Main(string[] args)
        {
            string firstNumberInGeorge = Console.ReadLine();
            string operation = Console.ReadLine();
            string secondNumberInGeorge = Console.ReadLine();

            BigInteger resultInInt = Calculate(GeorgeToInt(firstNumberInGeorge), GeorgeToInt(secondNumberInGeorge), operation);
            Console.WriteLine(IntToGeorge(resultInInt));

        }

        private static BigInteger GeorgeToInt(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i += 3)
            {
                result.Append(georgeToIntDictionary[input.Substring(i, 3)]);
            }

            return BigInteger.Parse(result.ToString());
        }

        private static string IntToGeorge(BigInteger numberInDec)
        {
            StringBuilder georgeBase = new StringBuilder();
            string numberInDecToString = numberInDec.ToString();

            foreach (char t in numberInDecToString)
            {
                int toApp = t-'0';
                string toAppend = intToGeorgeDictionary[toApp];
                georgeBase.Append(toAppend);
            }

            return georgeBase.ToString();
        }

        private static BigInteger Calculate(BigInteger a, BigInteger b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                default:
                    return -1;
            }
        }

    }
}
