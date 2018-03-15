using System;
class Program
{
    static void Main()
    {
        double pointsAvailable = double.Parse(Console.ReadLine());
        string nameOfTheArena = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        string itemType = Console.ReadLine();

        double priceForAllItems = 0;

        switch (itemType)
        {
            case "Poor":
                priceForAllItems = 7000;
                break;
            case "Normal":
                priceForAllItems = 14000;
                break;
            case "Legendary":
                priceForAllItems = 21000;
                break;
        }

        double discount = 0;

        switch (nameOfTheArena)
        {
            case "Nagrand" when dayOfWeek == "Monday" || dayOfWeek == "Wednesday":
                discount = 0.05;
                break;
            case "Gurubashi" when dayOfWeek == "Tuesday" || dayOfWeek == "Thursday":
                discount = 0.10;
                break;
            case "Dire Maul" when dayOfWeek == "Friday" || dayOfWeek == "Saturday":
                discount = 0.07;
                break;
        }

        priceForAllItems = priceForAllItems - priceForAllItems * discount;

        double priceForOneItem = priceForAllItems / 5;

        int successfulPurchases = 0;

        for (int item = 1; item <= 5 && pointsAvailable >= priceForOneItem; item++)
        {
            pointsAvailable -= priceForOneItem;
            successfulPurchases++;
        }

        Console.WriteLine($"Items bought: {successfulPurchases}");
        Console.WriteLine($"Arena points left: {pointsAvailable}");

        if (successfulPurchases == 5)
        {
            Console.WriteLine("Success!");
        }
        else
        {
            Console.WriteLine("Failure!");
        }
    }
}