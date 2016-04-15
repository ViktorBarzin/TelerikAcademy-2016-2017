using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int number = 0;
            //check if number
            if (int.TryParse(input, out number))
            {
                if (number > 1 && number < 11)
                {
                    Console.WriteLine("yes {0}", number);
                }
                else
                {
                    Console.WriteLine("no {0}", number);
                }
            }
            else
            {
                switch (input)
                {
                    case "J": Console.WriteLine("yes {0}", input);
                        break;
                    case "Q": Console.WriteLine("yes {0}", input);
                        break;
                    case "K": Console.WriteLine("yes {0}", input);
                        break;
                    case "A": Console.WriteLine("yes {0}", input);
                        break;
                    default: Console.WriteLine("no {0}", input);
                        break;
                }
            }
        }
    }
}
