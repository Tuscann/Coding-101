using System;

class Programs
{
    static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        int fuelConsumption = int.Parse(Console.ReadLine());
        decimal fuelPrice = decimal.Parse(Console.ReadLine());
        decimal money = int.Parse(Console.ReadLine());

        decimal moneyNeeded = fuelPrice * fuelConsumption * distance / 100;

        if (money >= moneyNeeded)
        {
            Console.WriteLine("You can go home. {0:F2} money left.", money - moneyNeeded);
        }
        else
        {
            Console.WriteLine("Sorry, you cannot go home. Each will receive {0:F2} money.", money / 5);
        }
    }
}