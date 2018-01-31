using System;
class Program
{
    static void Main()
    {
        double distance = double.Parse(Console.ReadLine());
        double consumption = double.Parse(Console.ReadLine()) * distance / 100.0;
        double fuelPrice = double.Parse(Console.ReadLine()) * consumption;
        double moneyAvailable = double.Parse(Console.ReadLine()) - fuelPrice;

        if (moneyAvailable < 0)
        {
            Console.WriteLine("Sorry, you cannot take a trip. Each will receive {0:f2} money.", (fuelPrice + moneyAvailable) / 5.0);
        }
        else
        {
            Console.WriteLine("You can take a trip. {0:f2} money left.", moneyAvailable);
        }
    }
}