using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        int wight = 2 * n + 3;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (wight - 3 - 2 * i) / 2));
        }
        Console.WriteLine("{0}*****{0}", new string('.', (wight - 5) / 2));
        Console.WriteLine("{0}", new string('*', wight));
        Console.WriteLine("{0}*****{0}", new string('.', (wight - 5) / 2));
        for (int i = n-2 ; i >= 0; i--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (wight - 3 - 2 * i) / 2));
        }
    }
}