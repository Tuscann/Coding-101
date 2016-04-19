using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int numRows = n - 1;
        if (n % 2 == 1) numRows++;
        Console.WriteLine(new string('%', 2 * n));
        for (int i = 0; i < numRows; i++)
        {
            Console.Write("%");
            Console.Write(new string(' ', n - 2));
            if (i == (n - 1) / 2)
                Console.Write("**");
            else
                Console.Write("  ");
            Console.Write(new string(' ', n - 2));
            Console.Write("%");
            Console.WriteLine();
        }
        Console.WriteLine("{0}", new string('%', 2 * n));
    }
}

