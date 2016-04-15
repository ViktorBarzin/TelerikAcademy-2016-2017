using System;
namespace _04.Rectangles
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2} {1:F2}", width * heigth, width * 2 + heigth * 2);
        }
    }
}
