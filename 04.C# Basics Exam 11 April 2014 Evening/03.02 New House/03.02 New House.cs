using System;

internal class Program
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var a = (n - 1) / 2;
        var b = 0;

        for (var i = 0; i < n - 2 - i; i++)
        {
            Console.WriteLine("{0}{1}*{1}{0}", new String('-', a), new String('*', b));
            a--;
            b++;
        }
        Console.WriteLine("{0}", new String('*', n));
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|", new String('*', n - 2));
        }
    }
}