using System;
class Program
{
    static void Main()
    {
        string planetName = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());

        double distance = 0;
        int maxdays = 0;

        if (planetName == "Mercury")
        {
            distance = 0.61;
            maxdays = 7;
        }
        else if (planetName == "Venus")
        {
            distance = 0.28;
            maxdays = 14;
        }
        else if (planetName == "Mars")
        {
            distance = 0.52;
            maxdays = 20;
        }
        else if (planetName == "Jupiter")
        {
            distance = 4.2;
            maxdays = 5;
        }
        else if (planetName == "Saturn")
        {
            distance = 8.52;
            maxdays = 3;
        }
        else if (planetName == "Uranus")
        {
            distance = 18.21;
            maxdays = 3;
        }
        else if (planetName == "Neptune")
        {
            distance = 29.09;
            maxdays = 2;
        }

        if (planetName == "Mercury" || planetName == "Venus" || planetName == "Mars" || planetName == "Jupiter" ||
            planetName == "Saturn" || planetName == "Uranus" || planetName == "Neptune")
        {
            if (days > maxdays)
            {
                Console.WriteLine("Invalid number of days! ");
            }
            else
            {
                Console.WriteLine("Distance: {0:f2}", 2.0 * distance);
                Console.WriteLine("Total number of days: {0:f2}", 2 * 226 * distance + days);
            }
        }
        else
        {
            Console.WriteLine("Invalid planet name!");
        }
    }
}