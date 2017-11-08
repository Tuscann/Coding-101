using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int leftDashes = 3 * n;
        int rightDashes = 2 * n - 2;
        int middleDashes = 1;
        int startingStars = 3 * n + 1;
        int middleDashes1 = n - 1;
        int middleDashes2 = n - 1;
        int middleDashes3 = n - 1;

        Console.WriteLine("{0}**{1}", new string('-', leftDashes), new string('-', rightDashes));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middleDashes), new string('-', rightDashes - 1));
            middleDashes++;
            rightDashes--;
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}*{1}", new string('*', startingStars), new string('-', middleDashes1));
        }

        for (int i = 0; i < n / 2; i++)
        {
            if (i + 1 == n / 2)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes - i), new string('*', middleDashes2 + i * 2), new string('-', middleDashes3 - i));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes - i), new string('-', middleDashes2 + i * 2), new string('-', middleDashes3 - i));
            }
        }
    }
}
