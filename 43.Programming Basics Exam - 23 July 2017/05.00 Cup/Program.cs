using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 5 * n;
        
        int counter = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n + i), new string('#', 3 * n - 2 * i));
            counter = 3 * n - 2 * i;
        }
        counter -= 4;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', (width - counter - 2) / 2), new string('.', counter));
            counter -= 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('.', 2 * n), new string('#', n));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n - 2), new string('#', n + 4));
        }
        Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (width - 10) / 2));
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n - 2), new string('#', n + 4));
        }
    }
}