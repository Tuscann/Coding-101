using System;
class Program
{
    static void Main()
    {
        int runDays = int.Parse(Console.ReadLine());

        double totalKilometers = 0;
        int totalMinutes = 0;

        for (int i = 0; i < runDays; i++)
        {
            int minutes = int.Parse(Console.ReadLine());
            totalMinutes += minutes;
            double distance = double.Parse(Console.ReadLine());
            string size = Console.ReadLine();

            if (size == "m")
            {
                totalKilometers += distance / 1000;
            }
            else if (size == "km")
            {
                totalKilometers += distance;
            }
        }
        double cal = totalMinutes / 20.00 * 400;
        Console.WriteLine("He ran {0:f2}km for {1} minutes and burned {2} calories.", totalKilometers, totalMinutes, cal);
    }
}