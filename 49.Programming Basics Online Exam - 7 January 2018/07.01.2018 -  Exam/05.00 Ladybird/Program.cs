using System;
class Program
{
    static void Main()  // 100/100    zero test ????
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}@   @", new string(' ', n - 2));
        Console.WriteLine("{0}\\_/", new string(' ', n - 1));
        Console.WriteLine("{0}/ \\", new string(' ', n - 1));
        Console.WriteLine("{0}|_|", new string(' ', n - 1));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}/{1}|{1}\\", new string(' ', n - i - 1), new string(' ', i));

        }
        int even = n % 2 == 0 ? 1 : 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("|{0}@{1}|{1}@{0}|", new string(' ', n / 2 - 1), new string(' ', n / 2 - even));
        }
        for (int i = n; i > n / 2 - even; i--)
        {
            if (i == n / 2 + 1 - even)
            {
                Console.WriteLine("{0} {1}|{1}", new string(' ', n - i - even), new string('^', i - 1 + even));
            }
            else
            {
                Console.WriteLine("{0}\\{1}|{1}/", new string(' ', n - i), new string(' ', i - 1));
            }
        }
    }
}