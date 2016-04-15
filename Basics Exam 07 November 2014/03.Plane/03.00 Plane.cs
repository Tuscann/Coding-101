using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', (3 * n - 1) / 2));

        var dotsBefore = n + (n / 2) - 1;
        var dotsMiddle = 1;

        for (int i = 0; i < n / 2 + 1; i++)
        {

            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
            dotsBefore--;
            dotsMiddle += 2;
        }
        dotsBefore = n;
        dotsMiddle = n + 2;

        for (int i = 0; i < n / 2; i++)
        {
            dotsBefore -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
            dotsMiddle += 4;
        }

        dotsBefore = n-2;
        dotsMiddle = n;
        int dotsBetween = 1;
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', dotsBefore), new string('.', dotsMiddle));

        for (int i = 0; i < n/2-1; i++)
        {
            dotsBefore -= 2;
            Console.WriteLine(
                "*{0}*{2}*{1}*{2}*{0}*",
                new string('.', dotsBefore),
                new string('.', dotsMiddle),
                new string('.', dotsBetween));
            dotsBetween += 2;
        }

        dotsBefore = n - 1;
        
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
            dotsBefore--;
            dotsMiddle += 2;
        }
        Console.WriteLine("{0}", new string('*', 3 * n));
    }
}

