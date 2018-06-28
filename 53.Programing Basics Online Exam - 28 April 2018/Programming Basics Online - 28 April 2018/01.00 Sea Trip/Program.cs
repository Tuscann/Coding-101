using System;
class Program
{
    static void Main()
    {
        double foodPrice = double.Parse(Console.ReadLine());
        double suveniriPrice = double.Parse(Console.ReadLine());
        double hotelMoney = double.Parse(Console.ReadLine());

        double sumForTransport = 420.0 / 100.0 * 7 * 1.85;
        double foodAndSouvenir = 3 * (foodPrice + suveniriPrice);

        double total = sumForTransport + foodAndSouvenir + hotelMoney * 0.9 + hotelMoney * 0.85 + hotelMoney * 0.8;

        Console.WriteLine("Money needed: {0:f2}", total);
    }
}