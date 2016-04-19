using System;
class Program
{
    static void Main()
    {

        int startExamHour = int.Parse(Console.ReadLine());
        int startExamMinutes = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();
        int hourDuration = int.Parse(Console.ReadLine());
        int minutesDuration = int.Parse(Console.ReadLine());

        int totalHours = startExamHour * 60 + startExamMinutes;
        int totalminDuration = hourDuration * 60 + minutesDuration;

        var total = totalHours + totalminDuration;
        var hours = Math.Abs(total / 60);
        var minutes = Math.Abs(total % 60);

        if (timeOfDay == "AM")
        {
            if (hours < 12)
            {
                Console.WriteLine("{0:00}:{1:00}:AM", hours, minutes);
            }
            else if (hours == 12)
            {
                Console.WriteLine("12:{0:00}:PM", minutes);
            }
            else if (hours > 12 && hours < 24)
            {
                hours = hours - 12;
                Console.WriteLine("{0:00}:{1:00}:PM", hours, minutes);
            }
            else if (hours == 24)
            {
                Console.WriteLine("00:{0:00}:PM", minutes);
            }

        }
        else if (timeOfDay == "PM")
        {
            if (hours < 12)
            {

                Console.WriteLine("{0:00}:{1:00}:PM", hours, minutes);
            }
            else if (hours == 12)
            {
                Console.WriteLine("12:{0:00}:AM", minutes);
            }
            else if (hours > 12 && hours < 24)
            {
                hours = hours - 12;
                Console.WriteLine("{0:00}:{1:00}:AM", hours, minutes);
            }
            else if (hours == 24)
            {
                Console.WriteLine("00:{0:00}:AM", minutes);
            }

        }
    }
}