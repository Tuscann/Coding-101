using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        var dateAsText = Console.ReadLine();
        var date = DateTime.ParseExact(dateAsText, "d-M-yyyy",CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);

    }
}

