using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        int dots = 0;
        int dotsbefore = n;

        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}^{1}{0}",
                new String('\'', dotsbefore), new String('^', dots));
            dotsbefore--;
            dots += 1;
        }
        dots = 1;
        dotsbefore = n - 1;
        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}^{1}{0}",
                new String('\'', dotsbefore), new String('^', dots));
            dotsbefore--;
            dots += 1;
        }
        for (int r = 0; r < n / 2 + 1; r++)
        {
            Console.WriteLine("{0}| |{0}",new String('\'', n-1));
        }
        Console.WriteLine("{0}", new String('-', 2 * n + 1));
    }
}