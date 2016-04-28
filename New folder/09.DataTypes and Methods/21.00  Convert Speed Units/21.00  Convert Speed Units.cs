using System;
class Program
{
    static void Main()
    {
        decimal distaneMeters = decimal.Parse(Console.ReadLine());
        decimal hours = decimal.Parse(Console.ReadLine());
        decimal minutes = decimal.Parse(Console.ReadLine());
        decimal seconds = decimal.Parse(Console.ReadLine());


        decimal metersperSecound = distaneMeters / 3600;
        Console.WriteLine("{0:f6}", metersperSecound);
        decimal kilomersperHour = distaneMeters * 1000 / hours;
        Console.WriteLine("{0:f6}", kilomersperHour);

    }
}

