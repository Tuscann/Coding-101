using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());
        decimal m = int.Parse(Console.ReadLine());

        decimal kurs = w * m;
        decimal total = x / (kurs);

        Console.WriteLine(Math.Ceiling(total));
    }
}

