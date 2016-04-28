using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductors
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                StringBuilder currentTicket = new StringBuilder(string.Format(Convert.ToString(int.Parse(Console.ReadLine()), 2)));
                for (int j = currentTicket.Length-1; j >= p.Length-1; j--)
                {
                    bool isMatch = true;
                    for (int k = p.Length - 1; k >= 0; k--)
                    {
                        if (p[k] != currentTicket[j-k])
                        {
                            isMatch = false;
                        }
                    }
                    if (isMatch)
                    {
                        for (int l = 0; l < p.Length; l++)
                        {
                            currentTicket[j - l] = '0';
                        }
                    }
                }
                string res = Convert.ToInt32(currentTicket.ToString(), 2).ToString();
                Console.WriteLine(res);
            }
        }
    }
}
