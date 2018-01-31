using System;
class Program
{
    static void Main()
    {
        double change = double.Parse(Console.ReadLine());
        double coins = 0;
        
        while (change > 0.001)
        {
            if (change >= 2)
            {
                coins += GetCoinsOf(2, change);
                change -= GetRemainderChange(2, change);

            }
            else if (change >= 1 && change < 2)
            {
                coins += Math.Floor(change);
                change -= Math.Floor(change);

            }
            else if (change < 1 && change >= 0.5)
            {
                coins += GetCoinsOf(0.5, change);
                change -= GetRemainderChange(0.5, change);

            }
            else if (change < 0.5 && change >= 0.2)
            {
                coins += GetCoinsOf(0.2, change);
                change -= GetRemainderChange(0.2, change);

            }
            else if (change < 0.2 && change >= 0.1)
            {
                coins += GetCoinsOf(0.1, change);
                change -= GetRemainderChange(0.1, change);

            }
            else if (change < 0.1 && change >= 0.05)
            {
                coins += GetCoinsOf(0.05, change);
                change -= GetRemainderChange(0.05, change);

            }
            else if (change < 0.05 && change >= 0.02)
            {
                coins += GetCoinsOf(0.02, change);
                change -= GetRemainderChange(0.02, change);

            }
            else if (change < 0.02 && change >= 0.01)
            {
                coins += GetCoinsOf(0.01, change);
                change -= GetRemainderChange(0.01, change);
            }

            change = Math.Round(change * 1000) / 1000.0;
        }
        Console.WriteLine("{0:f0}",coins);
    }

    private static double GetRemainderChange(double coin, double change)
    {
        return Math.Floor(change / coin) * coin;
    }

    private static double GetCoinsOf(double coin, double change)
    {
        return Math.Floor(change / coin);
    }
}