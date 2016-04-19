using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{1}{0}{1}", new string('*', n + 1), new string(' ', (2 * n - (n + 1)) / 2));

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', (2 * n - (n + 1)) / 2), new string(' ', n - 1));
        }
        int empty = (n - 1) / 2;
        int emptyInside = n - 1;
        
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            empty--;
            emptyInside += 2;
            Console.WriteLine("{0}*{1}*{0}", new string(' ', empty), new string(' ', emptyInside));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
        }

        Console.WriteLine("{0}", new string('*', 2 * n));
    }
}

