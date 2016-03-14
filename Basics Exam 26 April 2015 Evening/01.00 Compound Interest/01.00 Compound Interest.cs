using System;

public class CompoundInterest
{
    public static void Main()
    {
        double priceOfTv = double.Parse(Console.ReadLine());
        int bankLoanTerm = int.Parse(Console.ReadLine());
        double bankInterestRate = double.Parse(Console.ReadLine());
        double friendInterest = double.Parse(Console.ReadLine());

        double bankPrice = Math.Pow((1 + bankInterestRate), bankLoanTerm) * priceOfTv;
        double friendPrice = (1 + friendInterest) * priceOfTv;

        double bestPrice = Math.Min(bankPrice, friendPrice);
        string bestLender = bankPrice < friendPrice ? "Bank" : "Friend";

        Console.WriteLine("{0:F2} {1}", bestPrice, bestLender);
    }
}