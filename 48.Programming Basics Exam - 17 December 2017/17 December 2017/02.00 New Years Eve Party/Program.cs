using System;
class Program
{
    static void Main() // 88/100
    {
        int geustCount = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double sum = geustCount * 20;

        if (budget >= sum)
        {
            double giftMoney = 0.6 * (budget - sum);
            double profit = 0.4 * (budget - sum);

            Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation.", Math.Floor(profit), Math.Floor(giftMoney));
        }
        else
        {
            Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more.", sum - budget);
        }
    }
}