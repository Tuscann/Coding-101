using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int witht = 3 * n + 6;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}~ ~ ~{0}", new string(' ', n));
        }
        Console.WriteLine("{0}", new string('=', witht - 1));
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            Console.WriteLine("|{0}~~~~{0}|{1}|", new string('~', n), new string(' ', witht - 7 - 2 * n));
        }
        Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', witht - 7 - 2 * n));

        int x = 0;
        if (n % 2 != 0)
        {
            x = (n - 2) / 2;
        }
        else
        {
            x = (n - 3) / 2;
        }

        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("|{0}~~~~{0}|{1}|", new string('~', n), new string(' ', witht - 7 - 2 * n));
        }
        Console.WriteLine("{0}", new string('=', witht - 1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string(' ', i), new string('@', witht - n - 2 - 2 * i));
        }
        Console.WriteLine("{0}", new string('=', witht - n));

    }
}