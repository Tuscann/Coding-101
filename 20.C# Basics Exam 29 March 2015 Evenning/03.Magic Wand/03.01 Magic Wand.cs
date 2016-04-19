using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int shirina = n * 3 + 1;

        Console.WriteLine("{0}{1}{0}", new string('.', shirina / 2), new string('*', 1));

        for (int i = 1; i <= n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (shirina / 2) - i), new string('*', 1), new string('.', (i * 2) - 1));
        }

        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));

        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('*', 1), new string('.', shirina - (i * 2 + 1)));
        }

        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', n / 2 - i), new string('.', n / 2), new string('.', i - 1), new string('.', n));
        }

        Console.WriteLine("{0}{1}*{2}*{1}{0}",new string('*',n/2+1),new string('.',n/2),new string('.',n));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', n));
        }
        Console.WriteLine("{0}{1}{0}", new string('.',n),new string('*', n + 2));


    }
}

