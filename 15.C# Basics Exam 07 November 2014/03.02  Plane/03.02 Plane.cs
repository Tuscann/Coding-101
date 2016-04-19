using System;
class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
      
        Console.WriteLine("{0}*{0}", new string('.', width / 2));
        int count = 1;
        for (int i = 0; i < n; i++)
        {
            if (i <= n / 2 + 1)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (width - 1 - 2 * i) / 2 - 1),
                     new string('.', 1 + 2 * i));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (width - 1 - 2 * i) / 2 - 1 - count),
                    new string('.', 1 + 2 * i + 2 * count));
                count++;
            }
        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2), new string('.', n));
        for (int i = 1; i <= n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', n - 2 - 2 * i),
                new string('.', 2 * i - 1), new string('.', n));
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - i), new string('.', n + 2 * i));
        }
        Console.WriteLine("{0}", new string('*', width));
    }
}