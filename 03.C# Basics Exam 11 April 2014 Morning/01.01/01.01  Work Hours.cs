using System;
class WorkHours
{
    static void Main()
    {
        int projectHours = int.Parse(Console.ReadLine());
        int availableDays = int.Parse(Console.ReadLine());
        int workTimePercentage = int.Parse(Console.ReadLine());

        decimal workDays = availableDays * 0.90m;
        int workHoursPerDay = 12;
        decimal workHours = Math.Floor(workDays * workHoursPerDay * workTimePercentage / 100.0m);

        if (projectHours <= workHours)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine(workHours - projectHours);
    }
}
