using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int gameYears = 30000;
        int weekendDays = n * 127;
        int worksDays = (365 - n) * 63;
        int result = weekendDays + worksDays;
        int lastResult = Math.Abs(gameYears - result);
        int hour = lastResult / 60;
        int minutes = lastResult % 60;
        if (gameYears >= result)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", hour, minutes);
        }
        else
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", hour, minutes);
        }
    }
}