using System;
class Program
{
    static void Main()
    {
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euro = decimal.Parse(Console.ReadLine());
        decimal levaB = decimal.Parse(Console.ReadLine());
        decimal levaM = decimal.Parse(Console.ReadLine());
        
        //decimal rublesrate = 100m *3.5m;
        decimal dollarsrate = 1.5m;
        decimal eurorate = 1.95m;
        
        decimal totalrubles = rubles / 100m * 3.5m;
        decimal totaldollars = dollars * dollarsrate;
        decimal totaleuro = euro * eurorate;
        decimal totallevaB = levaB / 2;

        decimal biggest = Math.Max(totalrubles, Math.Max(totaldollars, Math.Max(totaleuro, Math.Max(totallevaB, levaM))));
        Console.WriteLine("{0:f2}",Math.Ceiling(biggest));
    }
}

