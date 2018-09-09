using System;

internal class Program
{
    public static void Main()
    {
        int sektorsCount = int.Parse(Console.ReadLine());
        int staduim = int.Parse(Console.ReadLine());
        double priceTicket = double.Parse(Console.ReadLine());

        double total = priceTicket * staduim / sektorsCount;

        Console.WriteLine("Total income - {0:f2} BGN", staduim * priceTicket);
        Console.WriteLine("Money for charity - {0:f2} BGN", (staduim * priceTicket - total * 0.75) / 8.0);
    }
}