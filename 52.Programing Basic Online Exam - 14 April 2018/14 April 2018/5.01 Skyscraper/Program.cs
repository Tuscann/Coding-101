using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("{0}|", new string(' ', n));
        }
        Console.WriteLine("{0}_|_", new string(' ', n - 1));

        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("{0}|-|", new string(' ', n - 1));
        }
        Console.WriteLine("{0}_|-|_", new string(' ', n - 2));
        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("{0}|***|", new string(' ', n - 2));
        }
        Console.WriteLine(" {0}|***|{0}", new string('_', n - 3));

        for (int i = 0; i < 4 * n - 1; i++)
        {
            Console.WriteLine(" {0}---{0}", new string('|', n - 2));
        }
        Console.WriteLine("_{0}---{0}_", new string('|', n - 2));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}", new string('|', 2 * n + 1));
        }
    }
}