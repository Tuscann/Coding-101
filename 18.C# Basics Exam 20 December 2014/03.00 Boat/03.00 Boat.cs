using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 0,count=0;i < n; i++)
        {
            if (i < n / 2)
            {
                Console.WriteLine("{0}{1}{2}", new string('.', n - 1 - 2 * count), new string('*', 1 + 2 * count), new string('.', n));
                count++;
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", new string('.', n - 1 - 2 * count), new string('*', 1 + 2 * count), new string('.', n));
                count--;
            }
        }
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', 2 * n - 2 * i));
        }

    }
}

