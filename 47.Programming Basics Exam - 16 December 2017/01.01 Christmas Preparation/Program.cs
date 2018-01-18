using System;
class Program
{
    static void Main()
    {
        int countHartiq = int.Parse(Console.ReadLine());
        int countRolki = int.Parse(Console.ReadLine());
        double litriLepilo = double.Parse(Console.ReadLine());
        int prozentSale = int.Parse(Console.ReadLine());

        double priceProlki = countHartiq * 5.80;
        double pricePolki = countRolki * 7.20;
        double priceLepilo = litriLepilo * 1.20;

        double sum = priceLepilo + pricePolki + priceProlki;
        double priceWithSale = sum - sum * prozentSale / 100;
        Console.WriteLine($"{priceWithSale:f3}");
    }
}