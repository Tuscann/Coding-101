using System;
class Program
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        if (year == "normal")
        {
            int weeks = 48;
            double x = ((weeks - hometown) * (3.0 / 4.0)) + (p * (2.0 / 3.0)) + hometown;
            Console.WriteLine(Math.Floor(x));
        }
        else if (year == "leap")
        {
            double x1 = (((48 - hometown) * (3.0 / 4.0)) + (p * (2.0 / 3.0)) + hometown) * 1.15;
            Console.WriteLine(Math.Floor(x1));
        }
    }
}



