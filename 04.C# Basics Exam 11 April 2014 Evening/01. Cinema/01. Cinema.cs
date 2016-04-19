using System;

internal class Program
{
    private static void Main()
    {
        var input = Console.ReadLine();
        var rows = decimal.Parse(Console.ReadLine());
        var columns = decimal.Parse(Console.ReadLine());

        var total = rows*columns;

        if (input == "Premiere")
        {
            total *= (decimal) 12.00;
        }
        else if (input == "Normal")
        {
            total *= (decimal) 07.50;
        }
        else
        {
            total *= (decimal) 05.00;
        }
        Console.WriteLine("{0:f2} leva", total);
    }
}