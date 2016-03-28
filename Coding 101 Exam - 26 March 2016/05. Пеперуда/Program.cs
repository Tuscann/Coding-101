using System;
class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        if (n == 3)
        {
            Console.WriteLine("*\\ /*");
            Console.WriteLine("{0}@{0}", new string(' ', (2 * n - 2) / 2));
            Console.WriteLine("*/ \\*");
        }
        else if (n == 5)
        {
            Console.WriteLine("{0}\\ /{0}", new string('*', (2 * n - 4) / 2));
            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', (2 * n - 4) / 2));

            }
            Console.WriteLine("{0}\\ /{0}", new string('*', (2 * n - 4) / 2));
            Console.WriteLine("{0}@{0}", new string(' ', (2 * n - 2) / 2));
            Console.WriteLine("{0}/ \\{0}", new string('*', (2 * n - 4) / 2));
            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.WriteLine("{0}/ \\{0}", new string('-', (2 * n - 4) / 2));

            }
            Console.WriteLine("{0}/ \\{0}", new string('*', (2 * n - 4) / 2));

        }
        else if (n >= 7)
        {
            Console.WriteLine("{0}\\ /{0}", new string('*', (2 * n - 4) / 2));
            for (int i = 0; i < (n - 4) / 2; i++)
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', (2 * n - 4) / 2));
                Console.WriteLine("{0}\\ /{0}", new string('*', (2 * n - 4) / 2));

            }
            Console.WriteLine("{0}\\ /{0}", new string('-', (2 * n - 4) / 2));
            Console.WriteLine("{0}\\ /{0}", new string('*', (2 * n - 4) / 2));
            Console.WriteLine("{0}@{0}", new string(' ', (2 * n - 2) / 2));
            Console.WriteLine("{0}/ \\{0}", new string('*', (2 * n - 4) / 2));

            for (int i = 0; i < (n - 4) / 2; i++)
            {
                Console.WriteLine("{0}/ \\{0}", new string('-', (2 * n - 4) / 2));
                Console.WriteLine("{0}/ \\{0}", new string('*', (2 * n - 4) / 2));

            }
            Console.WriteLine("{0}/ \\{0}", new string('-', (2 * n - 4) / 2));
            Console.WriteLine("{0}/ \\{0}", new string('*', (2 * n - 4) / 2));
        }
    }
}c

