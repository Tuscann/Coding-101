using System;
class Program
{
    static void Main()   // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        ;
        int weight = 5 * n;

        Console.WriteLine("{0}{1}{0}", new string('-', (weight - n) / 2), new string('*', n));
        int middle = n + 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}{2}{1}*{0}", new string('-', (weight - n - 4) / 2 - 2 * i),
                new string('*', i), new string('&', middle));
            middle += 2;
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}**{1}**{0}", new string('-', n - 1 - i), new string('~', weight - 4 - 2 * n + 2 + 2 * i));
            middle += 2;
        }
        Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2), new string('|', weight - n - 2));
        for (int i = n / 2; i > 0; i--)
        {
            middle -= 2;
            Console.WriteLine("{0}**{1}**{0}", new string('-', n - i), new string('~', weight - 4 - 2 * n + 2 * i));
        }

        for (int i = n / 2; i > 0; i--)
        {
            middle -= 2;
            Console.WriteLine("{0}*{1}{2}{1}*{0}", new string('-', (weight - n - 4) / 2 - 2 * i + 2),
                new string('*', i - 1), new string('&', middle));
        }
        Console.WriteLine("{0}{1}{0}", new string('-', (weight - n) / 2), new string('*', n));
    }
}