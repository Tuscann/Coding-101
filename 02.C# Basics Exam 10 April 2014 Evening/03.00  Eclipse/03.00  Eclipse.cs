using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(" {0} {1} {0} ", new String('*', 2 * n - 2), new string(' ', n - 1));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new String('/', 2 * n - 2), new string(' ', n - 1));
        }
        Console.WriteLine("*{0}*{1}*{0}*", new String('/', 2 * n - 2), new string('-', n - 1));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new String('/', 2 * n - 2), new string(' ', n - 1));
        }
        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new String(' ', 1), new String('*', 2 * n - 2), new string(' ', n - 1));
    }
}