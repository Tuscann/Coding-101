using System;
class Program
{
    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());

        decimal restDays = input * 127;
        decimal workingDays = (365 - input) * 63;
        decimal totalDays = restDays + workingDays;

        if (30000 >= totalDays)
        {
            decimal days = Math.Floor((30000 - totalDays) / 60);
            decimal hours = (30000 - totalDays) % 60;

            Console.WriteLine("Tom sleeps well \n{0:f0} hours and {1} minutes less for play", days, hours);
        }
        else
        {
            decimal days = Math.Floor((totalDays - 30000) / 60);
            decimal chasove = (totalDays - 30000) % 60;

            Console.WriteLine("Tom will run away \n{0:f0} hours and {1} minutes more for play", days, chasove);
        }
    }
}