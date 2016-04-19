using System;

class Program
{
    static void Main()
    {
        decimal BG = decimal.Parse(Console.ReadLine());
        decimal rate = 1.79549m;
        decimal dollars = BG * rate;
        Console.WriteLine("{0:0.00} BGN", dollars);
    }
}

