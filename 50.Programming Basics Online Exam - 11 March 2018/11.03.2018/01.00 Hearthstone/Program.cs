using System;
class Program
{
    static void Main()
    {
        int rest = int.Parse(Console.ReadLine());
        double priceCard = double.Parse(Console.ReadLine());
        double priceAdventure = double.Parse(Console.ReadLine());
        double priceCoffee = double.Parse(Console.ReadLine());
        
        Console.WriteLine("{0:f2}", 3 * priceCard + 2 * priceAdventure + priceCoffee);
        Console.WriteLine(rest - 15);
    }
}