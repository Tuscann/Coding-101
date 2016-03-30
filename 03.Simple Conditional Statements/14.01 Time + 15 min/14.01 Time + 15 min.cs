using System;

class Program
{
    static void Main()
    {
        var hour = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        var totalMin = minutes + 15;
        var totalHour = hour + totalMin / 60;
        var minutesAfterHour = totalMin % 60;

        if (totalHour == 24)
        {
            Console.WriteLine("0:{0:00}", minutesAfterHour);
        }
        else
        {
            Console.WriteLine("{0:0}:{1:00}", totalHour, minutesAfterHour);
        }

    }
}

