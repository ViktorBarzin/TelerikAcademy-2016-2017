using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(int.Parse(Console.ReadLine()),1,1);
            Console.WriteLine(DateTime.IsLeapYear(date.Year) ? "Leap" : "Common");
        }
    }
}
