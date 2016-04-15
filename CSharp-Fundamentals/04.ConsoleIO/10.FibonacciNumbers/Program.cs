using System;

class Program
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        long a = 0;
        long b = 1;

        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.Write("0, 1, ");
            for (int i = 2; i < n; i++)
            {
                long temp;
                temp = a + b;
                a = b;
                b = temp;
                if (i + 1 != n)
                {
                    Console.Write("{0}, ", temp);
                }
                else
                {
                    Console.Write(temp);
                }

            }
        }
    }
}

