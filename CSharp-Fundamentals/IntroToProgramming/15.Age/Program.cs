using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('.');
            DateTime birthday = new DateTime(int.Parse(input[2]), int.Parse(input[0]), int.Parse(input[1]));
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthday.Year;

            
            if (age > 0)
            {
                Console.WriteLine(age-1);
                Console.WriteLine(age + 9);
            }
            else
            {
                Console.WriteLine(age);
                Console.WriteLine(age + 10);
            }
        }
    }
}
