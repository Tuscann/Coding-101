using System;
class Program
{
    static void Main()
    {
        decimal FG = decimal.Parse(Console.ReadLine());
        decimal FGA = decimal.Parse(Console.ReadLine());
        decimal P3 = decimal.Parse(Console.ReadLine());
        decimal TOV = decimal.Parse(Console.ReadLine());
        decimal ORB = decimal.Parse(Console.ReadLine());
        decimal OppORB = decimal.Parse(Console.ReadLine());
        decimal FT = decimal.Parse(Console.ReadLine());
        decimal FTA = decimal.Parse(Console.ReadLine());

        decimal EFG = (FG + (decimal)0.5 * P3) / FGA;
        decimal TOVV = TOV / (FGA + (decimal)0.44 * FTA + TOV);
        decimal ORBB = ORB / (ORB + OppORB);
        decimal FTT = FT / FGA;

        Console.WriteLine("eFG% {0:f3}\nTOV% {1:f3}\nORB% {2:f3}\nFT% {3:f3}", EFG, TOVV, ORBB, FTT);
    }
}