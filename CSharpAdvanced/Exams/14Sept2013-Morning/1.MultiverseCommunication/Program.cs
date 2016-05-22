using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MultiverseCommunication
{
    class Program
    {
        private static Dictionary<string, string> baseDictionary = new Dictionary<string, string>()
        {
            {"CHU","0"},
            {"TEL","1" },
            {"OFT","2" },
            {"IVA","3" },
            {"EMY","4" },
            {"VNB","5" },
            {"POQ","6" },
            {"ERI","7" },
            {"CAD","8" },
            {"K-A","9" },
            {"IIA","A" },
            {"YLO","B" },
            {"PLA","C" }
        };
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder inputToBase13 = new StringBuilder();

            for (int i = 0; i < input.Length; i+=3)
            {
                inputToBase13.Append(baseDictionary[input.Substring(i, 3)]);
            }

            Console.WriteLine(StringToInt(inputToBase13.ToString()));
        }

        private static ulong StringToInt(string input)
        {
            // Select base characters
            const string CHARACTERS = "0123456789ABC";
            // Select base
            const int CBASE = 13;
            ulong results = 0;
            foreach (char digit in input.ToUpper().ToArray())
            {
                results = ((ulong)CBASE * results) + (ulong)CHARACTERS.ToUpper().IndexOf(digit);
            }

            return results;
        }
    }
}
