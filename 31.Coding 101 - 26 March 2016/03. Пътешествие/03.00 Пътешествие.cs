using System;
class Program
{
    static void Main()
    {
        decimal budjet = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        decimal total = (decimal)0;
        if (season == "summer")
        {
            if (budjet <= 100)
            {
                total = (decimal)0.7 * budjet;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", budjet - total);
            }
            else if (budjet <= 1000)
            {

                total = (decimal)0.6 * budjet;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", budjet - total);
            }
            else if (budjet > 1000)
            {
                total = (decimal)0.9 * budjet;

                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", total);
            }
        }
        else
        {
            if (budjet <= 100)
            {
                total = (decimal)0.3 * budjet;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", budjet - total);
            }
            else if (budjet <= 1000)
            {
                total = (decimal)0.2 * budjet;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", budjet - total);
            }
            else if (budjet > 1000)
            {
                total = (decimal)0.9 * budjet;

                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", total);
            }
        }
    }
}