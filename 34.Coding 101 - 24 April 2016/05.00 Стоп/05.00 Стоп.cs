using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));

        int before = n;
        int inside = 2 * n - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}//{1}\\\\{0}", new string('.', before), new string('_', inside));
            before--;
            inside += 2;
        }
        Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', 2 * n - 3));

        before = 0;
        inside = n * 4 - 1;
        //inside = 2 * (n + 1) + (2 * n + 1) - 2 - 2;

        for (int i = n; i > 0; i--)
        {
            Console.WriteLine("{0}\\\\{1}//{0}", new string('.', before), new string('_', inside));
            before++;
            inside -= 2;
        }
    }
}