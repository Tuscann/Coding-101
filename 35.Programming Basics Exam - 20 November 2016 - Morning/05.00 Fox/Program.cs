using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int lenght = 2 * n - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('*', 1 + i), new string('-', lenght - 2 * i));
        }
        for (int i = 0; i < n / 3; i++)
        {
            Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', n - 2 * i));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('-', 1 + i), new string('*', lenght - 2 * i));
        }
    }
}