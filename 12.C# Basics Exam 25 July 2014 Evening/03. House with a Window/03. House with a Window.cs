using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dotsBefore = n - 3;
        int dotsInside = 1;

        Console.WriteLine("{0}*{0}", new String('.', n - 1));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(".{0}*{1}*{0}.", new String('.', dotsBefore), new string('.', dotsInside));
            dotsInside += 2;
            dotsBefore--;
        }
        Console.WriteLine("*{0}*", new String('.', 2 * n - 3));
        Console.WriteLine("{0}", new String('*', 2 * n - 1));
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new String('.', 2 * n - 3));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new String('.', n / 2), new string('*', n - 3));
        }
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new String('.', (2 * n - 1) - 2));
        }
        Console.WriteLine("{0}", new String('*', 2 * n - 1));
    }
}