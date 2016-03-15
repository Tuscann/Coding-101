using System;
class Program
{
    static void Main()
    {
        decimal PriceTV = int.Parse(Console.ReadLine());
        int retarnYears = int.Parse(Console.ReadLine());
        decimal bankInterest = decimal.Parse(Console.ReadLine());
        decimal friendIterst = decimal.Parse(Console.ReadLine());


        decimal bankInterestRate = 1 + bankInterest;
        double bankLoan = (double)PriceTV * Math.Pow((double)bankInterestRate, retarnYears);
        //Console.WriteLine(bankLoan);
        double friandLoan = (double)PriceTV * (1 + (double)friendIterst);
        //Console.WriteLine(friandLoan);

        if (bankLoan < friandLoan)
        {
            Console.WriteLine("{0:f2} Bank", bankLoan);
        }
        else
        {
            Console.WriteLine("{0:f2} Friend", friandLoan);
        }

    }
}

