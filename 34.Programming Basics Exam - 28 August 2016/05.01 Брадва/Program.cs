using System;
class Program
{
    static void Main()   // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int innerdashes = 1;
        int outerdashes =2 * n - 3;
        Console.WriteLine("{0}**{1}", new string('-', 3 * n), new string('-', (2 * n) - 2));
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', innerdashes), new string('-', outerdashes));
            innerdashes++;
            outerdashes--;
        }
        innerdashes = n - 1;
        outerdashes = n - 1;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('*', 3 * n), new string('-', innerdashes), new string('-', outerdashes));
        }
        int lastdashes = 3 * n;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', lastdashes), new string('-', innerdashes), new string('-', outerdashes));
                lastdashes--;
                innerdashes += 2;
                outerdashes--;
            }
            else
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', lastdashes), new string('-', innerdashes), new string('-', outerdashes));
                lastdashes--;
                innerdashes += 2;
                outerdashes--;
            }
            if (i == n / 2 - 2)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', lastdashes), new string('*', innerdashes), new string('-', outerdashes));
            }
        }
        if (n == 2)
        {
            Console.WriteLine("------***-");
        }
    }
}