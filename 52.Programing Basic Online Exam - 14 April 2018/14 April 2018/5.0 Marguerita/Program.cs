using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int wight = 8 * n + 2;

        Console.WriteLine("\'&${0}", new string('\'', wight - 3));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}\\{1}", new string('\'', i + 2), new string('\'', wight - i - 3));
        }
        for (int i = 0; i < (wight - 1) / 2; i++)
        {
            Console.Write("^*");
        }
        Console.WriteLine("^\'");
        int before = 0;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}\\\\{1}\\{2}//{3}", new string('\'', before), new string(' ', n), new string(' ', wight - n - i * 2 - 6), new string('\'', before + 1));
            before++;
        }
        before++;
        Console.WriteLine("{0}\\{1}/{2}", new string('\'', n - 1), new string('~', wight - 2 * n - 1), new string('\'', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}\\{1}/{2}", new string('\'', before), new string(' ', wight - 2 * n - 2 * i - 3), new string('\'', before + 1));
            before++;
        }
        Console.WriteLine("{0}\\{1}/{2}", new string('\'', before), new string('_', wight - 2 * n - before - 1), new string('\'', before + 1));
        Console.WriteLine("{0}\\{1}/{2}", new string('\'', before + 1), new string('.', wight - 2 * n - before - 3), new string('\'', before + 2));
        before += 2;
        for (int i = 0; i < 2 * n - 2; i++)
        {
            Console.WriteLine("{0}\\{1}/{2}", new string('\'', 2 * n + i), new string(' ', wight - (2 * n + i) - (2 * n + 1 + i) - 2), new string('\'', 2 * n + 1 + i));
            before--;
        }
        Console.WriteLine("{0}\\___/{0}\'", new string('\'', (wight - 5) / 2));
        for (int i = 0; i < n * 2 + 1; i++)
        {
            Console.WriteLine("{0}|||{1}", new string('\'', wight / 2 - 2), new string('\'', wight / 2 - 1));
        }
        Console.WriteLine("{0}\'", new string('_', wight - 1));
        Console.WriteLine("\'{0}\'\'", new string('-', wight - 3));
    }
}