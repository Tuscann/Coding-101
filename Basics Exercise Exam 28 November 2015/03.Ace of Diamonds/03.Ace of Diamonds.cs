using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", new string('*', n));
        for (int row = 0; row < (n - 2) / 2; row++)
        {
     Console.WriteLine("*{0}{1}{0}*", new string('-', ((n - 2) / 2) - row), new string('@', 1 + row * 2));
        }
        for (int row = 0; row <= (n - 2) / 2; row++)
        {
      Console.WriteLine("*{0}{1}{0}*", new string('-', row), new string('@', n - 2 - (row * 2)));
        }
        Console.WriteLine("{0}", new string('*', n));
    }
}
