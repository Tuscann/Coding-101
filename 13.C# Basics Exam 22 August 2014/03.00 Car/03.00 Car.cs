using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = n;
        int stars = n;
        int dotsMiddle = stars;


        Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', stars));

        int dotsbefore = n - 1;
        int dotMiddle = n;

        for (int i = 1; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsbefore), new string('.', dotMiddle));
            dotMiddle += 2;
            dotsbefore -= 1;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n/2+1), new string('.',2*n-2));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 3 * n - 2));
        }

        Console.WriteLine("{0}", new string('*', 3 * n));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', n / 2), new string('.', (n / 2 - 1)), new string('.', 2 * n - (2 * (n / 2 + 1))));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', n / 2), new string('*', n / 2 + 1), new string('.', 2 * n - (2 * (n / 2 + 1))));



    }
}

