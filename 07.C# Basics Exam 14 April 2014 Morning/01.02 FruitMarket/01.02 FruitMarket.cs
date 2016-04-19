using System;
using System.Collections.Generic;
class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        double totalPrice = 0;
        //Dictionary<double, string> orders = new Dictionary<double, string>();
        for (int i = 0; i < 3; i++)
        {
            double quantity = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();

            if (dayOfWeek == "Friday" || dayOfWeek == "Sunday")
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else if (dayOfWeek == "Tuesday" && (product == "banana" || product == "apple" || product == "orange"))
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else if (dayOfWeek == "Wednesday" && (product == "tomato" || product == "cucumber"))
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else if (dayOfWeek == "Thursday" && product == "banana")
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else
            {
                totalPrice += quantity * PriceList(product);
            }

        }
        Console.WriteLine("{0, 0:F2}", totalPrice);
    }

    public static double Discounts(string dayOfWeek)
    {
        Dictionary<string, double> discounts = new Dictionary<string, double>()
        {
            {"Friday", 0.9},
            {"Sunday", 0.95},
            {"Tuesday", 0.8},
            {"Wednesday", 0.9},
            {"Thursday", 0.7}
        };

        return discounts[dayOfWeek];
    }

    public static double PriceList(string product)
    {
        Dictionary<string, double> priceList = new Dictionary<string, double>()
        {
            {"banana", 1.80},
            {"cucumber", 2.75},
            {"tomato", 3.20},
            {"orange", 1.60},
            {"apple", 0.86}
        };
        return priceList[product];
    }
}