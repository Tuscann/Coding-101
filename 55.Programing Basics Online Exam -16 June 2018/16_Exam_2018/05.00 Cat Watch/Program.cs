using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int space = n;
        int downSlash = n - 2;

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}||{1}||{0}", new string(' ', space), new string('_', downSlash));
        }
        Console.WriteLine("{0}//{1}\\\\{0}", new string(' ', n - 1), new string(' ', n));

        for (int i = 1; i <= n - 4; i++)
        {
            Console.Write("{0}||{1}||", new string(' ', n - 2), new string(' ', n + 2));
            if (i == (n - 3) / 2)
            {
                Console.WriteLine("]");
            }
            else
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine("{0}\\\\{1}//{0}", new string(' ', n - 1), new string(' ', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}||{1}||{0}", new string(' ', n), new string('_', n - 2));
        }
    }
}
