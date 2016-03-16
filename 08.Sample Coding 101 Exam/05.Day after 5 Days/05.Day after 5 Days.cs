using System;
class DateAfter5Days
{
    static void Main()
    {
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());

        var daysInTheMounth = 0;
             if (month == 4 || month == 6 || month == 9 || month == 11) { daysInTheMounth = 30; }
        else if (month == 2) { daysInTheMounth = 28; }
        else { daysInTheMounth = 31; }
        day = day + 5;

        if (day > daysInTheMounth) { day = day - daysInTheMounth; month = (month % 12) + 1; }

        if (month <= 9) { Console.WriteLine("{0}.0{1}", day, month); }
        else { Console.WriteLine("{0}.{1}", day, month); }
    }
}

