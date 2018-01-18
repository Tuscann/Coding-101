using System;
class Program
{
    static void Main()  // 100/100
    {
        int peoples = int.Parse(Console.ReadLine());
        int alMoney = int.Parse(Console.ReadLine());

        int price = peoples * 20;
        if (price > alMoney)
        {
            int t = price - alMoney;
            Console.WriteLine($"They won't have enough money to pay the covert. They will need {t} lv more.");
        }
        else
        {
            int all = alMoney - price;
            double priceFoerverki = all * 0.4;
            double dareniq = all - priceFoerverki;
            Console.WriteLine($"Yes! {Math.Round(priceFoerverki)} lv are for fireworks and {Math.Round(dareniq)} lv are for donation. ");
        }
    }
}