using System;

class Sunglasses
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', 2 * n));
        var rowOfNosodurjackata = n;
        if (n % 2 == 1)
        {
            rowOfNosodurjackata = n / 2;
        }
        else
        {
            rowOfNosodurjackata = n / 2 - 1;
        }
        for (int row = 1; row <= n - 2; row++)
        {
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.Write("*");
            if (rowOfNosodurjackata != row)
            {
                Console.Write(new string(' ', n));
            }
            else
            {
                Console.Write(new string('|', n));
            }
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.WriteLine("*");
        }
        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', 2 * n));
    }
}

