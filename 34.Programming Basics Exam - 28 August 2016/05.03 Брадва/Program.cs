using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            Console.Write(new string('-', 3 * n));
            Console.Write("*");
            Console.Write(new string('-', row));
            Console.Write("*");
            Console.WriteLine(new string('-', 2 * n - 2 - row));
        }
        for (int row = 0; row < n / 2; row++)
        {
            Console.Write(new string('*', 3 * n));
            Console.Write("*");
            Console.Write(new string('-', n - 1));
            Console.Write("*");
            Console.WriteLine(new string('-', n - 1));
        }
        for (int row = 0; row < n / 2; row++)
        {
            Console.Write(new string('-', 3 * n - row));
            Console.Write("*");
            if (row == n / 2 - 1)
            {
                Console.Write(new string('*', n - 1 + 2 * row));
            }
            else
            {
                Console.Write(new string('-', n - 1 + 2 * row));
            }
                
            Console.Write("*");
            Console.WriteLine(new string('-', n - row - 1));
        }
    }
}