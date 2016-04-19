using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dotsOut = 0;
        int dotsInside = n - 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new String('.', dotsOut), new String('*', dotsInside));
            dotsOut++;
            dotsInside -= 2;
        }
        if (n < 12)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}||{0}", new String('.', (n - 2) / 2));
            }
            Console.WriteLine("{0}", new String('-', n));
        }
        else
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("{0}||{0}", new String('.', (n - 2) / 2));
            }
            for (int i = 0; i < n - (n / 2 - 2) - n / 2; i++)
            {
                Console.WriteLine("{0}", new String('-', n));
            }
        }
    }
}
