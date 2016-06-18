using System;
namespace _07.PointInACircle
{
    class Program
    {
        static void Main()
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(X * X + Y * Y);

            if (distance <= 2)
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }
        }
    }
}
