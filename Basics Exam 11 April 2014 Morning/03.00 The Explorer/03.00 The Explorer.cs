using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('-', n / 2));

        int dotbefore = (n - 3) / 2;
        int dotsinside = 1;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', dotbefore), new string('-', dotsinside));
            dotbefore--;
            dotsinside += 2;

        }
        Console.WriteLine("*{0}*", new string('-', n - 2));

        dotbefore = 1;
        dotsinside = n - 4;

        for (int i = n / 2 - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', dotbefore), new string('-', dotsinside));
            dotbefore++;
            dotsinside -= 2;
        }
        Console.WriteLine("{0}*{0}", new string('-', n / 2));

    }
}

