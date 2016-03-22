using System;

class Cars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = n;
        int stars = n;
        int dotsMiddle = stars;

        Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', stars));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            dots--;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', dotsMiddle));
            dotsMiddle += 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', dots), new string('.', n * 2 - 2));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 3 - 2));
        }

        int middleDots = (n / 2 + 1) + (n - 6) / 2;
        Console.WriteLine(new string('*', n * 3));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                new string('.', n / 2), new string('.', n / 2 - 1), new string('.', middleDots));
        }

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', n / 2), new string('*', n / 2 + 1), new string('.', middleDots));
    }
}
