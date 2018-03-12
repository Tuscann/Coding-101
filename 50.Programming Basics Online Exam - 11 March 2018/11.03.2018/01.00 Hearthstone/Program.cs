using System;
class Program
{
    static void Main()
    {
        int rest = int.Parse(Console.ReadLine());
        double priceCard = double.Parse(Console.ReadLine());
        double priceAdventure = double.Parse(Console.ReadLine());
        double priceCoffee = double.Parse(Console.ReadLine());

        double after = 3 * priceCard + 2 * priceAdventure + priceCoffee;
        Console.WriteLine("{0:f2}", after);
        Console.WriteLine(rest - 15);
    }
}
