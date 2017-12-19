using System;
class Program
{
    static void Main() // 100/100
    {
        int geustCount = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        int moneyCollected = geustCount * 20;

        if (budget > moneyCollected)
        {
            double giftMoney = 0.6 * (budget - moneyCollected);
            double profit = 0.4 * (budget - moneyCollected);

            Console.WriteLine("Yes! {0:f0} lv are for fireworks and {1:f0} lv are for donation.",profit, giftMoney);
        }
        else
        {
            Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more.", moneyCollected - budget);
        }
    }
}