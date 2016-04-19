using System;
class Program
{
    static void Main()
    {
        decimal moneyKiro = decimal.Parse(Console.ReadLine());
        decimal goesut = decimal.Parse(Console.ReadLine());
        decimal hometown = decimal.Parse(Console.ReadLine());
        const int rent = 150;
        decimal normalWeekends = (4 - hometown) * 4 * 10;
        decimal weekDaysGointOut = goesut * ((Math.Floor((decimal)0.03 * moneyKiro)) + 10);

        decimal normalWeekDays = (22 - goesut) * 10;

        decimal total = rent + normalWeekDays + weekDaysGointOut + normalWeekends;

        if (moneyKiro > total)
        {
            Console.WriteLine("Yes, leftover {0:f0}.", moneyKiro - total);
        }
        else if (moneyKiro < total)
        {
            Console.WriteLine("No, not enough {0:f0}.", total - moneyKiro);
        }
        else if (moneyKiro == total)
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}

