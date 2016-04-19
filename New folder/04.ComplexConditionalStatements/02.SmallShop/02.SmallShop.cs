using System;

class Program
{
    static void Main()
    {
        var product = Console.ReadLine().ToLower();
        var city = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());
        var prize = 0.0;
        if (city == "sofia")
        {
            if (product == "coffee") { prize = 0.50; }
            else if (product == "water") { prize = 0.80; }
            else if (product == "beer") { prize = 1.20; }
            else if (product == "sweets") { prize = 1.45; }
            else if (product == "peanuts") { prize = 1.60; }

        }
        else if (city == "plovdiv")
        {
            if (product == "coffee") { prize = 0.40; }
            else if (product == "water") { prize = 0.70; }
            else if (product == "beer") { prize = 1.15; }
            else if (product == "sweets") { prize = 1.30; }
            else if (product == "peanuts") { prize = 1.50; }
        }
        else if (city == "varna")
        {
            if (product == "coffee") { prize = 0.45; }
            else if (product == "water") { prize = 0.70; }
            else if (product == "beer") { prize = 1.10; }
            else if (product == "sweets") { prize = 1.35; }
            else if (product == "peanuts") { prize = 1.55; }
        }
        Console.WriteLine("{0}", quantity * prize);
    }
}

