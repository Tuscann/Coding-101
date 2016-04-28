using System;
class Program
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", new String('-', 2 * n));

        for (int j = 0; j < n - 2; j++)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("{0}", new String('\\', n / n));
                Console.Write("{0}", new String('/', n / n));
            }
            Console.WriteLine("-");
        }
        Console.WriteLine("{0}", new String('-', 2 * n));
    }
}