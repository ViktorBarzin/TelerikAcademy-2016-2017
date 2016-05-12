using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TriangleSurfaceByThreeSides
{
    class Program
    {
        static void Main(string[] args)
        {
            // √	 p	 (	p	−	a	) 	(	p	−	b	)	 (	p	−	c	)    
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double perimeter = a + b + c;
            Console.WriteLine("{0:F2}", Math.Sqrt((perimeter / 2 * (perimeter / 2 - a) * (perimeter / 2 - b) * (perimeter / 2 - c))));
        }
    }
}
