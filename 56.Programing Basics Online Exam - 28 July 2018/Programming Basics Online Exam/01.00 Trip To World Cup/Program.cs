using System;

internal class Program
{
    public static void Main()
    {
        double TicketGo = double.Parse(Console.ReadLine());
        double TicketReturn = double.Parse(Console.ReadLine());
        double TicketPerMatch = double.Parse(Console.ReadLine());
        int countMatches = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double total = 6 * (TicketGo + TicketReturn) * (1 - discount / 100.0) + 6 * countMatches * TicketPerMatch;

        Console.WriteLine("Total sum: {0:f2} lv.", total);
        Console.WriteLine("Each friend has to pay {0:f2} lv.", total / 6.0);
    }
}