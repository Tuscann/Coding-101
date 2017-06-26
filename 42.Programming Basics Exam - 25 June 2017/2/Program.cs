using System;
class Program
{
    static void Main()
    {
        decimal seconds = decimal.Parse(Console.ReadLine());
        decimal distance_meters = decimal.Parse(Console.ReadLine());
        decimal time_seconds = decimal.Parse(Console.ReadLine());

        decimal total = distance_meters * time_seconds + Math.Floor(distance_meters / 15) * (decimal)12.5;

        if (seconds <= total)
        {
            Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", total - seconds);
        }
        else if (seconds > total)
        {
            Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", total);
        }
    }
}