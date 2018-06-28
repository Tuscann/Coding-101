using System;
class Program
{
    static void Main()
    {
        int priceVIdeo = int.Parse(Console.ReadLine());
        int priceprovodnik = int.Parse(Console.ReadLine());
        double pricePerDay = double.Parse(Console.ReadLine());
        double profitPerDay = double.Parse(Console.ReadLine());

        double totalSpent = (priceVIdeo + priceprovodnik) * 13 + 1000;
        double totalNetIncPerGpu = (profitPerDay - pricePerDay) * 13;

        Console.WriteLine("{0}", totalSpent);
        Console.WriteLine("{0}", Math.Ceiling(totalSpent / totalNetIncPerGpu));
    }
}