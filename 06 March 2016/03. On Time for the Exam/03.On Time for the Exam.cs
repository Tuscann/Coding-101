using System;
class Program
{
    static void Main()
    {
        var startExamHour = int.Parse(Console.ReadLine());
        var startExamMinutes = int.Parse(Console.ReadLine());
        var comeHour = int.Parse(Console.ReadLine());
        var comeMinutes = int.Parse(Console.ReadLine());
        
        var examTime = startExamHour * 60 + startExamMinutes;
        var comeTime = comeHour * 60 + comeMinutes;
        var minutesDifference = comeTime - examTime;
        var hours = Math.Abs(minutesDifference / 60);
        var minutes = Math.Abs(minutesDifference % 60);

        if (minutesDifference < -30) { Console.WriteLine("Early"); }
        else if (minutesDifference < 0) { Console.WriteLine("On time"); }
        else if (minutesDifference == 0) { Console.WriteLine("On time"); }
        else { Console.WriteLine("Late"); }
        
        if (hours > 0)
        {
            if (minutes < 10)
                Console.Write(hours + ":0" + minutes + " hours");
            else
                Console.Write(hours + ":" + minutes + " hours");
        }
        else
            Console.Write(minutes + " minutes");
        if (minutesDifference < 0)
            Console.WriteLine(" before the start");
        else
            Console.WriteLine(" after the start");
    }
}






