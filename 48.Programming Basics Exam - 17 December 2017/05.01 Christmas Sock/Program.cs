using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("|{0}|", new string('-', 2 * n));
        Console.WriteLine("|{0}|", new string('*', 2 * n));
        Console.WriteLine("|{0}|", new string('-', 2 * n));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("|{0}{1}{0}|", new string('-', n - 1 - i), new string('~', 2 + 2 * i));
        }
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("|{0}{1}{0}|", new string('-', 2 + i), new string('~', 2 * n - 4 - 2 * i));
        }

        for (int row = 0; row < n + 3; row++)
        {
            if (row == n / 2)
            {
                Console.WriteLine("{0}\\{1}MERRY{1}\\", new string('-', row), new string('.', (2 * n + 1 - 5) / 2));
            }
            else if (row == n / 2 + 2)
            {
                Console.WriteLine("{0}\\{1}X-MAS{1}\\", new string('-', row), new string('.', (2 * n + 1 - 5) / 2));
            }
            else if (row == n + 2)
            {
                Console.Write("{0}\\{1})", new string('-', row), new string('_', 2 * n + 1));
            }
            else
            {
                Console.WriteLine("{0}\\{1}\\", new string('-', row), new string('.', 2 * n + 1));
            }
        }
    }
}