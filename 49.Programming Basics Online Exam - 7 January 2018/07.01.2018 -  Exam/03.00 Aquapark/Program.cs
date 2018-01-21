using System;
class Program
{
    static void Main()  // 100/100
    {
        string month = Console.ReadLine().ToLower();
        int hours = int.Parse(Console.ReadLine());
        int peopleCount = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine().ToLower();

        double price = 0.0;

        if (month == "march" || month == "april" || month == "may")
        {
            if (timeOfDay == "day")
            {
                price = 10.50;
            }
            else if (timeOfDay == "night")
            {
                price = 8.4;
            }
        }
        else if (month == "june" || month == "july" || month == "august")
        {
            if (timeOfDay == "day")
            {
                price = 12.60;
            }
            else if (timeOfDay == "night")
            {
                price = 10.20;
            }
        }
        if (peopleCount >= 4)
        {
            price *= 0.9;
        }
        if (hours >= 5)
        {
            price *= 0.5;
        }
        Console.WriteLine("Price per person for one hour: {0:f2}", price);
        Console.WriteLine("Total cost of the visit: {0:f2}", price * hours * peopleCount);
    }
}
