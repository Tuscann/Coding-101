using System;

namespace _02._00_Mountain_Run
{
    class Program
    {
        static void Main()
        {
            decimal recordInSeconds = decimal.Parse(Console.ReadLine());
            decimal distanceInMeters = decimal.Parse(Console.ReadLine());
            decimal timeInSeconds = decimal.Parse(Console.ReadLine());

            decimal result = distanceInMeters * timeInSeconds + Math.Floor(distanceInMeters / 50) * 30;

            if (recordInSeconds <= result)
            {
                Console.WriteLine("No! He was {0:f2} seconds slower.", result - recordInSeconds);
            }
            else
            {
                Console.WriteLine("Yes! The new record is {0:f2} seconds.", result);
            }
        }
    }
}
