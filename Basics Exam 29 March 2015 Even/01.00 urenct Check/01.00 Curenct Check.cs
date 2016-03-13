using System;

class CurrencyCheck
{
    static void Main()
    {
        double priceRubles = double.Parse(Console.ReadLine());
        double priceDollars = double.Parse(Console.ReadLine());
        double priceEuro = double.Parse(Console.ReadLine());
        double priceSpecialOfferLeva = double.Parse(Console.ReadLine());
        double priceMorzoneLeva = double.Parse(Console.ReadLine());

        //Get all prices in leva for 1 game;
        priceRubles = (priceRubles / 100) * 3.5;
        priceDollars *= 1.5;
        priceEuro *= 1.95;
        priceSpecialOfferLeva /= 2;

        //Get lowest price;
        double lowestPrice = double.MaxValue;
        lowestPrice = Math.Min(priceRubles, lowestPrice);
        lowestPrice = Math.Min(priceDollars, lowestPrice);
        lowestPrice = Math.Min(priceEuro, lowestPrice);
        lowestPrice = Math.Min(priceSpecialOfferLeva, lowestPrice);
        lowestPrice = Math.Min(priceMorzoneLeva, lowestPrice);

        //Print the result;
        Console.WriteLine("{0:F}", lowestPrice);
    }
}