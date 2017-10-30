using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 4 * n + 1;

        Console.WriteLine("{0}", new string('#', height));

        for (int i = 0; i < n; i++)
        {
            if (i == n / 2)
            {
                Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                    new string('.', i + 1),
                    new string('#', height / 2 - (2 * i + 1)),
                    new string(' ', n / 2 - 1));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{1}{3}",
                    new string('.', i + 1),
                    new string('#', height / 2 - (2 * i + 1)),
                    new string(' ', 1 + i * 2),
                    new string('.', i + 1));
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', n + 1 + i),
                new string('#', height - 2 * (n + 1 + i)));
        }
    }
}