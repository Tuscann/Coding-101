using System;
class ExamSchedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        if (partOfDay == "PM")
        {
            startHour += 12;

            if (startHour == 24)
            {
                startHour = 0;
            }
        }

        DateTime startTime = new DateTime(2014, 04, 09, startHour, startMinutes, 0);
        DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);
        Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}
