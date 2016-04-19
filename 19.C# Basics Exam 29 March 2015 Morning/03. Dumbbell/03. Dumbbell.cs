using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}", new String('.', n / 2), new String('&', n / 2 + 1), new String('.', n));

        int dots = n / 2 - 2;
        int sa = n / 2;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(".{0}&{1}&{2}&{1}&{0}.", new String('.', dots), new String('*', sa), new String('.', n));
            dots--;
            sa++;
        }

        Console.WriteLine("&{0}&{1}&{0}&", new String('*', n - 2), new String('=', n));

        dots = 0;
        sa = n - 3;

        for (int i = n / 2 - 1; i > 0; i--)
        {
            Console.WriteLine(".{0}&{1}&{2}&{1}&{0}.", new String('.', dots), new String('*', sa), new String('.', n));
            dots++;
            sa--;
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new String('.', n / 2), new String('&', n / 2 + 1), new String('.', n));

    }
}

