using System;
class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        decimal rows = decimal.Parse(Console.ReadLine());
        decimal columns = decimal.Parse(Console.ReadLine());

        decimal total = rows * columns;

        if (input == "Premiere")
        {
            total *= (decimal)12.00;
        }
        else if (input == "Normal")
        {
            total *= (decimal)07.50;
        }
        else
        {
            total *= (decimal)05.00;
        }
        Console.WriteLine("{0:f2} leva", total);
    }
}

