using System;
class Programs
{
    static void Main()
    {
        string month = Console.ReadLine();
        int hours = int.Parse(Console.ReadLine());
        int groupSize = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();
        double price = 0;

        switch (month)
        {
            case "march":
            case "april":
            case "may":
                {
                    switch (dayTime)
                    {
                        case "day":
                            price = 10.5;
                            break;
                        case "night":
                            price = 8.4;
                            break;
                    }

                    break;
                }
            case "june":
            case "july":
            case "august":
                switch (dayTime)
                {
                    case "day":
                        price = 12.6;
                        break;
                    case "night":
                        price = 10.2;
                        break;
                }

                break;
        }

        if (groupSize >= 4)
        {
            price *= 0.9;
        }

        if (hours >= 5)
        {
            price *= 0.5;
        }

        Console.WriteLine("Price per person for one hour: {0:F2}", price);
        Console.WriteLine("Total cost of the visit: {0:F2}", price * groupSize * hours);
    }
}