using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            Console.Write("*");
            for (int i = 1; i < n; i++)
            { Console.Write(" *"); }
            Console.WriteLine();
        }
    }
}

