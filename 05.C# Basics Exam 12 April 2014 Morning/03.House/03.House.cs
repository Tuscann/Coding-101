using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', n / 2));
        
        int dotsbefore = (n - 5) / 2;
        int dotsmiddle = 1;

        for (int i = 0; i < ((n + 1) / 2) - 2; i++)
        {
            Console.WriteLine(".{0}*{1}*{0}.", new string('.', dotsbefore), new string('.', dotsmiddle));
            dotsmiddle += 2;
            dotsbefore--;
        }
        Console.WriteLine("{0}", new string('*', n));

        for (int i = 0; i < (n + 1) / 2-2 ; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n / 4), new string('.', n - n / 4 - n / 4 - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - n / 4 - n / 4));
    }
}

