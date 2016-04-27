using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());

        decimal total = (((decimal)52 - b) * ((decimal)2 / (decimal)3)) + a / (decimal)2 + b;

        if (input == "t")
        {
            total = 3 + total;
        }
        Console.WriteLine("{0:f0}", Math.Floor(total));
    }
}