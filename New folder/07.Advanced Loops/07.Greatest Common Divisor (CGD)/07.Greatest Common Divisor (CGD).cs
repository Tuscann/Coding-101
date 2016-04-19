using System;

class Program
{
    static void Main()
    {

        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int oldb = b;
            b = a % b;
            a = oldb;
        }
        Console.WriteLine("{0}",a,b);
    }
}

