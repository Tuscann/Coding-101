using System;
class Program
{
    static void Main() // 40/100
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("|{0}|", new string('-', 2 * n));
        Console.WriteLine("|{0}|", new string('*', 2 * n));
        Console.WriteLine("|{0}|", new string('-', 2 * n));

        int before = (2 * n - 2) / 2;
        for (int i = 0; i <= (2 * n - 3) / 2; i++)
        {
            Console.WriteLine("|{0}{1}{0}|", new string('-', before - i), new string('~', 2 + 2 * i));
        }
        for (int i = (2 * n - 3) / 2 - 1; i >= 0; i--)
        {
            Console.WriteLine("|{0}{1}{0}|", new string('-', before - i), new string('~', 2 + 2 * i));
        }
        int counter = 0;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}\\", new string('-', i), new string('.', 2 * n + 1));
            counter = i;
        }
        counter++;
        Console.WriteLine("{0}\\{1}MERRY{1}\\", new string('-', counter), new string('.', (2 * n + 1 - 5) / 2));
        counter++;
        Console.WriteLine("{0}\\{1}\\", new string('-', counter), new string('.', 2 * n + 1));
        counter++;
        Console.WriteLine("{0}\\{1}X-MAS{1}\\", new string('-', counter), new string('.', (2 * n + 1 - 5) / 2));
        counter++;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}\\", new string('-', counter + i), new string('.', 2 * n + 1));
        }
        Console.WriteLine("{0}\\{1})", new string('-', n + 3 - 1), new string('_', 2 * n + 1));
    }

}
