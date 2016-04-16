using System;
class Program
{
    private static object dateTime;
    static void Main()
    {
        double lampConsumption = 100.53;
        double compConsumption = 125.90;
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        DateTime time = DateTime.Parse(text);

        int totalFlats = floors * flats;
        int totalComputars = 0;
        int totalLamps = 0;
        
        if (time >= Convert.ToDateTime("14:00") && time <= Convert.ToDateTime("18:59"))
        {
            totalComputars = totalFlats * 2;
            totalLamps = totalFlats * 2;
        }
        else if (time >= Convert.ToDateTime("19:00") && time <= Convert.ToDateTime("23:59"))
        {
            totalComputars = totalFlats * 6;
            totalLamps = totalFlats * 7;
        }
        else if (time >= Convert.ToDateTime("00:00") && time <= Convert.ToDateTime("08:59"))
        {
            totalComputars = totalFlats * 8;
            totalLamps = totalFlats * 1;
        }
        double result = Math.Floor(totalLamps * lampConsumption + totalComputars * compConsumption);

        Console.WriteLine("{0} Watts", result);
    }
}