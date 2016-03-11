using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());
        double flatsInDorms = floors * flats;
        double lampConsumption = 100.53;
        double compConsumption = 125.90;
        int totalConsumption = 0;
        if (time.Hour >= 14 && time.Hour <= 18)
        {  double noon = compConsumption * 2 + lampConsumption * 2;
            totalConsumption = (int)(noon * flatsInDorms);
        }
        else if (time.Hour >= 19 && time.Hour <= 23)
        {   double afterNoon = lampConsumption * 7 + compConsumption * 6;
            totalConsumption = (int)(afterNoon * flatsInDorms);
        }
        else if (time.Hour >= 0 && time.Hour <= 8)
        {   double midnight = compConsumption * 8 + lampConsumption;
            totalConsumption = (int)(midnight * flatsInDorms);
        }
        else{ totalConsumption = 0;} Console.WriteLine("{0} Watts", totalConsumption);
    }
}