using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int width = (4 * n) + 1;

        Console.WriteLine(new string('#', width));

        for (int row = 0; row < n; row++)
        {
            if (row == n / 2)
            {
                Console.WriteLine(new string('.', row + 1) + new string('#', width / 2 - (2 * row + 1))
                                  + new string(' ', n / 2 - 1) + "(@)" + new string(' ', n / 2 - 1)
                                  + new string('#', width / 2 - (2 * row + 1)) + new string('.', row + 1));
            }
            else
            {
                Console.WriteLine(new string('.', row + 1) + new string('#', width / 2 - (2 * row + 1))
                                  + new string(' ', 1 + row * 2) + new string('#', width / 2 - (2 * row + 1))
                                  + new string('.', row + 1));
            }
        }

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine(new string('.', n + 1 + row) + new string('#', width - 2 * (n + 1 + row))
                              + new string('.', n + 1 + row));
        }
    }
}