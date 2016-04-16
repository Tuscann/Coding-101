using System;
public class FruitMarket
{
    public static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        decimal quantity3 = decimal.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        decimal totalPrice =
            quantity1 * GetPrice(product1, dayOfWeek) +
            quantity2 * GetPrice(product2, dayOfWeek) +
            quantity3 * GetPrice(product3, dayOfWeek);
        Console.WriteLine("{0:f2}", totalPrice);
    }

    static decimal GetPrice(string productName, string dayOfWeek) 
        // Assign standard price and check for fruit
    {
        decimal price = 0;
        bool isFruit = false;
        switch (productName)
        {
            case "banana": price = 1.80m; isFruit = true; break;
            case "cucumber": price = 2.75m; break;
            case "tomato": price = 3.20m; break;
            case "orange": price = 1.60m; isFruit = true; break;
            case "apple": price = 0.86m; isFruit = true; break;
        }                                        // Apply the daily discounts

        switch (dayOfWeek)
        {
            case "Friday":
                price = price * 0.90m;
                break;
            case "Sunday":
                price = price * 0.95m;
                break;
            case "Tuesday":
                if (isFruit)
                    price = price * 0.80m;
                break;
            case "Wednesday":
                if (!isFruit)
                    price = price * 0.90m;
                break;
            case "Thursday":
                if (productName == "banana")
                    price = price * 0.70m;
                break;
        }

        return price;
    }
}
