using System;
class Program
{
    static void Main()
    {
        double points = double.Parse(Console.ReadLine());
        string areaName = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        string itemCondition = Console.ReadLine();
        double discount = 0;

        if (areaName == "Nagrand")
        {
            if (dayOfWeek == "Monday" || dayOfWeek == "Wednesday")
            {
                discount = 5.0 / 100.0;
            }
        }
        else if (areaName == "Gurubashi")
        {
            if (dayOfWeek == "Tuesday" || dayOfWeek == "Thursday")
            {
                discount = 10.0 / 100.0;
            }
        }
        else if (areaName == "Dire Maul")
        {
            if (dayOfWeek == "Friday" || dayOfWeek == "Saturday")
            {
                discount = 7.0 / 100.0;
            }
        }
        double priceAllItems = 0;
        if (itemCondition == "Poor")
        {
            priceAllItems = 7000;
        }
        else if (itemCondition == "Normal")
        {
            priceAllItems = 14000;
        }
        else if (itemCondition == "Legendary")
        {
            priceAllItems = 21000;
        }

        priceAllItems -=  priceAllItems * discount;
        double priceOneThing = priceAllItems / 5;
        int itemsBought = 0;

        while (true)
        {
            if (points - priceOneThing < 0 || itemsBought >= 5)
            {
                break;
            }
            points -= priceOneThing;
            itemsBought++;
        }

        Console.WriteLine("Items bought: " + itemsBought);
        Console.WriteLine("Arena points left: " + points);

        if (itemsBought >= 5)
        {
            Console.WriteLine("Success!");
        }
        else
        {
            Console.WriteLine("Failure!");
        }
    }
}