using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}**{0}", new string('-', n + 2));
        }
        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("{0}****{0}", new string('-', n + 1));
        }
        Console.WriteLine("{0}******{0}", new string('-', n));

        for (int i = 0; i < n - 4; i++)
        {
            Console.WriteLine("{0}**--**{0}", new string('-', n));
        }
        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("{0}**----**{0}", new string('-', n - 1));
        }
        Console.WriteLine("{0}**********{0}", new string('-', n - 2));

        for (int i = n - 3; i > 0; i--)
        {
            Console.WriteLine("{0}**{1}**{0}", new string('-', i), new string('-', 2 * n - 2 * i + 2));
        }
        Console.WriteLine("***{0}***", new string('-', 2 * n));
    }
}