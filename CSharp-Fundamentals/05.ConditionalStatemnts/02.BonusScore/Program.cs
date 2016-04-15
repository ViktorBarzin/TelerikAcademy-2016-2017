using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score > 0 && score < 4)
            {
                Console.WriteLine(score * 10);
            }
            else if (score > 3 && score < 7)
            {
                Console.WriteLine(score * 100);
            }
            else if (score > 6 && score < 10)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
