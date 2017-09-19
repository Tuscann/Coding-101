using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int weight = 3 * n;
        Console.WriteLine("{0}x{0}", new string('.', (weight - 1) / 2));
        Console.WriteLine("{0}/x\\{0}", new string('.', (weight - 3) / 2));
        Console.WriteLine("{0}x|x{0}", new string('.', (weight - 3) / 2));
        for (int i = n / 2; i >= 1; i--)
        {
            Console.WriteLine("{0}{1}|{1}{0}", new string('.', i), new string('x', (weight - 1 - 2 * i) / 2));
        }
        Console.WriteLine("{0}|{0}", new string('x', (weight - 1) / 2));
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}|{1}{0}", new string('.', i), new string('x', (weight - 1 - 2 * i) / 2));
        }
        Console.WriteLine("{0}/x\\{0}", new string('.', (weight - 3) / 2));
        Console.WriteLine("{0}\\x/{0}", new string('.', (weight - 3) / 2));
        for (int i = n / 2; i >= 1; i--)
        {
            Console.WriteLine("{0}{1}|{1}{0}", new string('.', i), new string('x', (weight - 1 - 2 * i) / 2));
        }
        Console.WriteLine("{0}|{0}", new string('x', (weight - 1) / 2));
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}|{1}{0}", new string('.', i), new string('x', (weight - 1 - 2 * i) / 2));
        }
        Console.WriteLine("{0}x|x{0}", new string('.', (weight - 3) / 2));
        Console.WriteLine("{0}\\x/{0}", new string('.', (weight - 3) / 2));
        Console.WriteLine("{0}x{0}", new string('.', (weight - 1) / 2));
    }
}