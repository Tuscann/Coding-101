using System;
class Program
{
    static void Main() //100/100
    {
        int startExamHour = int.Parse(Console.ReadLine());
        int startExamMinutes = int.Parse(Console.ReadLine());
        int comeHour = int.Parse(Console.ReadLine());
        int comeMinutes = int.Parse(Console.ReadLine());

        int examTime = startExamHour * 60 + startExamMinutes;
        int comeTime = comeHour * 60 + comeMinutes;
        int minutesDifference = comeTime - examTime;
        int hours = Math.Abs(minutesDifference / 60);
        int minutes = Math.Abs(minutesDifference % 60);

        if (minutesDifference < -30) { Console.WriteLine("Early"); }
        else if (minutesDifference < 0) { Console.WriteLine("On time"); }
        else if (minutesDifference == 0) { Console.WriteLine("On time"); }
        else { Console.WriteLine("Late"); }

        if (hours > 0)
        {
            if (minutes < 10)
            {
                Console.Write(hours + ":0" + minutes + " hours");
            }
            else
            {
                Console.Write(hours + ":" + minutes + " hours");
            }
        }
        else
        {
            Console.Write(minutes + " minutes");
        }

        if (minutesDifference < 0)
        {
            Console.WriteLine(" before the start");
        }
        else
        {
            Console.WriteLine(" after the start");
        }
    }
}
