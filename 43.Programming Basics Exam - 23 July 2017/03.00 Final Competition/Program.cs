using System;
class Program
{
    static void Main()
    {
        int dancers = int.Parse(Console.ReadLine());
        double points = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string country = Console.ReadLine();

        double money = dancers * points;

        double moneyAfterCosts = 0;
        if (country == "Bulgaria")
        {
            if (season == "summer")
            {
                moneyAfterCosts = money - 0.05 * money;
            }
            else if (season == "winter")
            {
                moneyAfterCosts = money - 0.08 * money;
            }
        }
        else
        {
            money *= 1.5;

            if (season == "summer")
            {
                moneyAfterCosts = money - 0.1 * money;
            }
            else if (season == "winter")
            {
                moneyAfterCosts = money - 0.15 * money;
            }
        }
        double charity = moneyAfterCosts * 0.75;
        double moneyleft = moneyAfterCosts - charity;
        double moneyPerDancer = moneyleft / dancers;

        Console.WriteLine("Charity - {0:f2}", charity);
        Console.WriteLine("Money per dancer - {0:f2}", moneyPerDancer);
    }
}