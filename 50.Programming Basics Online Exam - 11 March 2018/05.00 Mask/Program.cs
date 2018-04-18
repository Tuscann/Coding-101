using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}/{1}|  |{1}\\", new string(' ', n - i - 1), new string(' ', i - 1));
        }
        Console.WriteLine("{0}", new string('-', n * 2 + 2));
        Console.WriteLine("|{0}_{1}_{0}|", new string(' ', (n - 3) / 2), new string(' ', n + 1));
        Console.WriteLine("|{0}@{1}@{0}|", new string(' ', (n - 3) / 2), new string(' ', n + 1));

        for (int row = 0; row < n / 2; row++)
        {
            Console.WriteLine($"|{new string(' ', 2 * n)}|");
        }

        Console.WriteLine("|{0}OO{0}|", new string(' ', (n * 2 - 2) / 2));
        Console.WriteLine("|{0}/  \\{0}|", new string(' ', (n * 2 - 4) / 2));
        Console.WriteLine("|{0}||||{0}|", new string(' ', (n * 2 - 4) / 2));

        for (int i = 1; i <= n + 1; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('\\', i), new string('`', 2 * n - 2 * i + 2), new string('/', i));
        }
    }
}