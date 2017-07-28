using System;
class Axe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine(new string('-', 3 * n) + "*" + new string('-', row) + "*" + new string('-', ((2 * n) - 2) - row));
        }

        for (int row = 0; row < n / 2; row++)
        {
            Console.WriteLine(new string('*', 3 * n + 1) + new string('-', n - 1) + "*" + new string('-', n - 1));
        }

        for (int row = 0; row < n / 2 - 1; row++)
        {
            Console.WriteLine(new string('-', 3 * n - row) + "*" + new string('-', n - 1 + (row * 2)) + "*" + new string('-', n - 1 - row));
            if (row == n / 2 - 2)
            {
                Console.WriteLine(new string('-', 3 * n - row - 1) + "*" + new string('*', n + 1 + (row * 2)) + "*" + new string('-', n - 2 - row));
            }
        }
        if (n == 2)
        {
            Console.WriteLine("------***-");
        }
    }
}
