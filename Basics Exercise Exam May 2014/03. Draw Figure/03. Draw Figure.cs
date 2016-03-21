using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", new string('*', n));
        for (int i = 1; i < n / 2; i++)
        { Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', n - 2 * i)); }

        Console.WriteLine("{0}*{0}", new string('.', n / 2));

        for (int i = n / 2 - 1; i >= 1; i--)
        {
            { Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', n - 2 * i)); }

        }
        Console.WriteLine("{0}", new string('*', n));

    }
}

