using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int height = 4 * n + 1;

        Console.WriteLine(new string('#', height));
        Console.WriteLine(".{0} {0}.", new string('#', 2 * n - 1));

        for (int i = 0; i < n - 1; i++)
        {
            if (i == (n - 2) / 2)
                Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                    new string('.', i + 2),
                    new string('#', 2 * n - 3 - 2 * i),
                    new string(' ', i)
                );
            else
                Console.WriteLine("{0}{1}{2} {2}{1}{0}",
                    new string('.', i + 2),
                    new string('#', 2 * n - 3 - 2 * i),
                    new string(' ', i + 1));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', n + 1 + i),
                new string('#', 2 * n - 1 - 2 * i));
        }
    }
}
