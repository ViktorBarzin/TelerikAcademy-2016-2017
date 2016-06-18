using System;
class BookExperience
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5)
        {
            Console.Write("inside circle");
        }
        else
        {
            Console.Write("outside circle");
        }
        if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1))
        {
            Console.WriteLine(" inside rectangle");
        }
        else
        {
            Console.WriteLine(" outside rectangle");
        }
    }
}