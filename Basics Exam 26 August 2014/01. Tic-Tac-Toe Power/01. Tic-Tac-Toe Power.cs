using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        int index = y * 3 + x + 1;
        int trueValue = value + y * 3 + x;


        Console.WriteLine((ulong)Math.Pow(trueValue, index));

        //if (x == 0 && y == 0)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value, 1));
        //}
        //else if (x == 0 && y == 1)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 3, 4));
        //}
        //else if (x == 0 && y == 2)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 6, 7));
        //}
        //else if (x == 1 && y == 0)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 1, 2));
        //}
        //else if (x == 1 && y == 1)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 4, 5));
        //}
        //else if (x == 1 && y == 2)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 7, 8));
        //}
        //else if (x == 2 && y == 0)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 2, 3));
        //}
        //else if (x == 2 && y == 1)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 5, 6));
        //}
        //else if (x == 2 && y == 2)
        //{
        //    Console.WriteLine((ulong)Math.Pow(value + 8, 9));
        //}
    }
}

