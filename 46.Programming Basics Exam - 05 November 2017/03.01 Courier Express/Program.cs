using System;
class CourierExpress
{
    public static void Main()  // 100/100
    {
        decimal weight = decimal.Parse(Console.ReadLine());
        string service = Console.ReadLine();
        int distance = int.Parse(Console.ReadLine());
        decimal pricePerKm = 0.0m;

        if (weight < 1.0m)
        {
            pricePerKm = 0.03m;
        }
        else if (weight >= 1.0m && weight <= 10)
        {
            pricePerKm = 0.05m;
        }
        else if (weight >= 11 && weight <= 40)
        {
            pricePerKm = 0.1m;
        }
        else if (weight >= 41 && weight <= 90)
        {
            pricePerKm = 0.15m;
        }
        else if (weight >= 91 && weight <= 150)
        {
            pricePerKm = 0.2m;
        }

        decimal priceForDelivery = distance * pricePerKm;

        decimal expressPrice = 0.0m;
        if (service == "express")
        {
            if (weight < 1.0m)
            {
                expressPrice = 0.8m * 0.03m;
            }
            else if (weight >= 1.0m && weight <= 10m)
            {
                expressPrice = 0.4m * 0.05m;
            }
            else if (weight >= 11m && weight <= 40m)
            {
                expressPrice = 0.05m * 0.1m;
            }
            else if (weight >= 41m && weight <= 90m)
            {
                expressPrice = 0.02m * 0.15m;
            }
            else if (weight >= 91m && weight <= 150m)
            {
                expressPrice = 0.01m * 0.2m;
            }
            priceForDelivery = expressPrice * weight * distance + priceForDelivery;
        }

        Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceForDelivery:f2} lv.");
    }
}