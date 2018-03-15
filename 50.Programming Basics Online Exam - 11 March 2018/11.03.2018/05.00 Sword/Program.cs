using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}/^\\{0}", new string('#', (2 * n - 2) / 2));

        int b = n - 2;
        int c = 3;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}.{1}.{0}", new string('#', b), new string(' ', c));
            b--;
            c += 2;
        }

        int d = (c - 3) / 2;

        Console.WriteLine("{0}|{1}S{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d));
        Console.WriteLine("{0}|{1}O{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d));
        Console.WriteLine("{0}|{1}F{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d));
        Console.WriteLine("{0}|{1}T{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d));

        for (int i = 0; i < n - 4; i++)
        {
            Console.WriteLine("{0}|{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d * 2 + 1));
        }
        //if (n == 4)
        //{
        //    Console.WriteLine("{0}|{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d * 2 + 1));
        //}

        Console.WriteLine("{0}|{1}U{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d));
        Console.WriteLine("{0}|{1}N{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d));
        Console.WriteLine("{0}|{1}I{1}|{0}", new string('#', (n - 1) / 2), new string(' ', d));
        Console.WriteLine("@{0}@", new string('=', 2 * n - 1));
        int spaces = 2 * n + 1 - (((n + 3) / 2) * 2 + 2);

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}|{1}|{0}", new string('#', (n + 3) / 2), new string(' ', spaces));
        }
        Console.WriteLine("{0}\\{1}/{0}", new string('#', (n + 3) / 2), new string('.', spaces));
    }
}