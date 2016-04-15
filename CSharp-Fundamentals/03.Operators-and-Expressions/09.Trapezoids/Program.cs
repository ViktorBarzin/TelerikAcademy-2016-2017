using System;
namespace _09.Trapezoids
{
    class Program
    {
        static void Main()
        {
            double a, b, h, area = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

            area = ((a + b) / 2) * h;

            Console.WriteLine("{0:F7}",area);
        }
    }
}
