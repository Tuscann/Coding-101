using System;
class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());

        double sumToPayAfterParking = 0.0;

        for (int daysCount = 1; daysCount <= days; daysCount++)
        {
            double currentSum = 0.0;
            for (int hoursCount = 1; hoursCount <= hours; hoursCount++)
            {
                if (daysCount % 2 == 0 && hoursCount % 2 != 0)
                {
                    currentSum += 2.50;
                }
                else if (daysCount % 2 != 0 && hoursCount % 2 == 0)
                {
                    currentSum += 1.25;
                }
                else
                {
                    currentSum += 1;
                }
            }
            Console.WriteLine($"Day: {daysCount} - {currentSum:F2} leva");
            sumToPayAfterParking += currentSum;
        }
        Console.WriteLine("Total: {0:F2} leva", sumToPayAfterParking);
    }
}