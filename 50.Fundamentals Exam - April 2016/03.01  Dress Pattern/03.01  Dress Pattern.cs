using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        //TOP
        Console.Write(new string('_', n * 4));
        Console.Write(".");
        Console.Write(new string('_', n * 4));
        Console.Write(".");
        Console.Write(new string('_', n * 4));
        Console.WriteLine();

        for (int row = 1; row <= n * 2; row++)
        {
            Console.Write(new string('_', n * 4 - row * 2));
            Console.Write(".");
            if (row == 1) Console.Write(new string('*', row * 2));
            else Console.Write(new string('*', row * 2 + row - 1));
            Console.Write(".");
            Console.Write(new string('_', n * 4 - row * 2));
            Console.Write(".");
            if (row == 1) Console.Write(new string('*', row * 2));
            else Console.Write(new string('*', row * 2 + row - 1));
            Console.Write(".");
            Console.Write(new string('_', n * 4 - row * 2));
            Console.WriteLine();
        }

        //UNDER THE (.)(.) + BELT :)

        for (int i = 0; i <= n; i++)
        {
            if (i < n)
            {
                Console.Write(".");
                Console.Write(new string('*', 12 * n));
                Console.Write(".");
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('.', n * 3));
                Console.Write(new string('*', (12 * n + 2) - n * 6));
                Console.Write(new string('.', n * 3));
                Console.WriteLine();
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('_', n * 3));
            Console.Write(new string('o', (12 * n + 2) - n * 6));
            Console.Write(new string('_', n * 3));
            Console.WriteLine();
        }

        //BOTTOM

        for (int row = 1; row <= n * 3; row++)
        {
            Console.Write(new string('_', n * 3 + 1 - row));
            Console.Write(".");
            if (row % 2 == 1) Console.Write(new string('*', n * 6 + (row - 1) * 2));
            else Console.Write(new string('*', n * 6 + (row - 1) * 2));
            Console.Write(".");
            Console.Write(new string('_', n * 3 + 1 - row));
            Console.WriteLine();
        }
        Console.WriteLine(new string('.', 12 * n + 2));
    }
}
