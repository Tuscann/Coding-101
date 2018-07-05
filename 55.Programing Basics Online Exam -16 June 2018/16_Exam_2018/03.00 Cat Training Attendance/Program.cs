using System;
class Program
{
    static void Main()
    {
        int startingHour = int.Parse(Console.ReadLine());
        int checkingHour = int.Parse(Console.ReadLine());
        int minutesOfChecking = int.Parse(Console.ReadLine());
        string dayOfWeek = Console.ReadLine();

        double bonus = 0.0;

        if (checkingHour + 1 <= startingHour)
        {
            bonus += 1.5;
        }
        else if (checkingHour == startingHour && minutesOfChecking <= 30)
        {
            bonus += 1;
        }
        else if (checkingHour == startingHour && minutesOfChecking > 30 || checkingHour < startingHour + 4)
        {
            bonus += 0.5;
        }

        switch (dayOfWeek)
        {
            case "Monday":
            case "Wednesday":
            case "Friday":
                bonus += 0.6;
                break;
            case "Tuesday":
            case "Thursday":
            case "Saturday":
                bonus += 0.8;
                break;
            case "Sunday":
                bonus += 2;
                break;
        }
        Console.WriteLine("{0:f2}", bonus);
    }
}