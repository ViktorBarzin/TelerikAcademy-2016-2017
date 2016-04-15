using System;
namespace _08.IsPrime
{
    class Program
    {
        static void Main()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            if (number == 0 || number == 1 || number < 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    
                }
                Console.WriteLine("true");
            }
        }
    }
}
