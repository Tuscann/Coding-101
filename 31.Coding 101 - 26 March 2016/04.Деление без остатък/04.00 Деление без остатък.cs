using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int p1 = 0;
        int p2 = 0;
        int p3 = 0;

        for (int i = 0; i < n; i++)
        {
            int k = int.Parse(Console.ReadLine());

            if (k % 2 == 0) { p1++; }
            if (k % 3 == 0) { p2++; }
            if (k % 4 == 0) { p3++; }
        }
        decimal x = ((decimal)p1 / (decimal)n) * 100;
        decimal x1 = ((decimal)p2 / (decimal)n) * 100;
        decimal x2 = ((decimal)p3 / (decimal)n) * 100;

        Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n", x, x1, x2);
    }
}