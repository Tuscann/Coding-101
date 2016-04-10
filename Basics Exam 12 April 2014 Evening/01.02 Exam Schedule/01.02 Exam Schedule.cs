using System;
internal class ExamSchedule
{
    private static void Main()
    {
        
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int examhours = int.Parse(Console.ReadLine());
        int examminutes = int.Parse(Console.ReadLine());
        
        DateTime start = DateTime.Parse(string.Format("{0}:{1} {2}", hour, minutes, partOfDay));
        
        start = start.AddHours(examhours);
        start = start.AddMinutes(examminutes);

        Console.WriteLine(start.ToString("hh:mm:tt"));
    }
}