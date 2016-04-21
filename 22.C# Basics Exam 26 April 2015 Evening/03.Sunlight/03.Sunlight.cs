using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new String('.', ((3 * n) - 1) / 2));

        int dotsbefore = 1;
        int dotsInside = (3 * n - 5) / 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new String('.', dotsbefore), new String('.', dotsInside));

            dotsbefore++;
            dotsInside--;
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new String('.', n), new String('*', n));
        }
        Console.WriteLine("{0}", new String('*', 3 * n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new String('.', n), new String('*', n));
        }
        dotsbefore = n - 1;
        dotsInside = n/2;
        
        for (int i = n - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new String('.', dotsbefore), new String('.', dotsInside));
            dotsbefore--;
            dotsInside++;
        }
        Console.WriteLine("{0}*{0}", new String('.', ((3 * n) - 1) / 2));
    }
}

