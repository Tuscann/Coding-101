using System;

class Program
{
    static void Main()
    {
        decimal distance = decimal.Parse(Console.ReadLine());
        decimal per100 = decimal.Parse(Console.ReadLine());
        decimal priceFuel = decimal.Parse(Console.ReadLine());
        decimal totalMoney = decimal.Parse(Console.ReadLine());

        decimal total = distance * per100 / 100;
        decimal moneyy = total * priceFuel;

        if (totalMoney - moneyy >= 0)
        {
            Console.WriteLine("You can take a trip. {0:f2} money left.", totalMoney - moneyy);
        }
        else
        {
            //Console.WriteLine(moneyy - totalMoney);
            decimal x = Math.Ceiling(moneyy - totalMoney) / 5.0m;

            Console.WriteLine("Sorry, you cannot take a trip. Each will receive {0:f2} money.",x);
        }
    }
}