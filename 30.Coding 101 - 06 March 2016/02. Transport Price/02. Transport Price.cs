using System;

class Program
{
    static void Main()
    {
        int miles = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();

        double total;

        if (miles < 20 && miles >= 1)
        {
            if (time == "day") { total = 0.7 + miles * 0.79; }
            else { total = 0.7 + miles * 0.90; }
        }
        else if (miles < 100) { total = miles * 0.09; }
        else { total = miles * 0.06; }
        Console.WriteLine(total);
    }
}

