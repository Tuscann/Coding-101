using System;
class Program
{
    static void Main()  // 100/100
    {
        string season = Console.ReadLine();
        string typegroup = Console.ReadLine();
        int numberStudents = int.Parse(Console.ReadLine());
        int numberNights = int.Parse(Console.ReadLine());
       
        double prize = 0;
        string sport = "";

        if (season == "Winter")
        {
            prize = 9.60;

            if (typegroup == "boys")
            {
                sport = "Judo";
            }
            else if (typegroup == "girls")
            {
                sport = "Gymnastics";
            }
            else if (typegroup == "mixed")
            {
                prize = 10;
                sport = "Ski";
            }
        }
        else if (season == "Spring")
        {
            prize = 7.20;
            if (typegroup == "boys")
            {
                sport = "Tennis";
            }
            else if (typegroup == "girls")
            {
                sport = "Athletics";
            }
            else if (typegroup == "mixed")
            {
                prize = 9.5;
                sport = "Cycling";
            }

        }
        else if (season == "Summer")
        {
            prize = 15;
            if (typegroup == "boys")
            {
                sport = "Football";
            }
            else if (typegroup == "girls")
            {
                sport = "Volleyball";
            }
            else if (typegroup == "mixed")
            {
                prize = 20;
                sport = "Swimming";
            }
        }
        double total = numberStudents * numberNights * prize;

        if (numberStudents >= 50)
        {
            total *= 0.5;
        }
        else if (numberStudents >= 20)
        {
            total *= 0.85;
        }
        else if (numberStudents >= 10)
        {
            total *= 0.95;
        }
        Console.WriteLine("{0} {1:f2} lv.", sport, total);
    }
}