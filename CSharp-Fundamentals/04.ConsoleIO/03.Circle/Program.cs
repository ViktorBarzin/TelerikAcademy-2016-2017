using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * (Math.Pow(radius, 2));
        double perimeter = (2 * Math.PI) * radius;

        Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
    }
}

