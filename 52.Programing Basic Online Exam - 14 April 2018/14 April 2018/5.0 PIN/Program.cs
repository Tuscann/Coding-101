using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("/`{0}{1}/`I{1}/`N{2}N", new string('P', 2 * n), new string(' ', n), new string(' ', 2 * n + 1));
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("| P{0}P{1}| I{1}| N{2}N{3}N", new string(' ', 2 * n - 2), new string(' ', n), new string(' ', i), new string(' ', 2 * n - i));
        }
        Console.WriteLine("| {0}{1}| I{1}| N{2}N{3}N", new string('P', 2 * n), new string(' ', n), new string(' ', n-1), new string(' ', n +1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("| {0}{1}| I{2}| N{3}N{4}N", new string('P', n / 2), new string(' ', 2 * n - n / 2 + n), new string(' ', n), new string(' ', n + i), new string(' ', n - i));
        }
        Console.WriteLine("\\_{0}{1}\\_I{2}\\_N{3}NN", new string('P', n / 2), new string(' ', 2 * n - n / 2 + n), new string(' ', n), new string(' ', 2 * n));
    }
}