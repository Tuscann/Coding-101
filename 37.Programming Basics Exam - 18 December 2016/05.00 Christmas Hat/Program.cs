using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 4 * n + 1;
        int dots = (width - 3) / 2;

        Console.WriteLine("{0}/|\\{0}", new string('.', dots));
        Console.WriteLine("{0}\\|/{0}", new string('.', dots));

        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots--), new string('-', i));
        }
        Console.WriteLine("{0}", new string('*', width));

        for (int i = 0; i < width; i++)   //TAZI CHAST , PREDPOSLEDNIQ RED !!
        {
            Console.Write(i % 2 == 0 ? '*' : '.');
        }
        Console.WriteLine();
        Console.WriteLine("{0}", new string('*', width));
    }
}