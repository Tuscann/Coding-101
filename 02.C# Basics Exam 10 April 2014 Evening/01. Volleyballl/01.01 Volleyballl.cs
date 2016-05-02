using System;
class Program
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        double x = ((48 - hometown) * (3.0 / 4.0)) + (p * (2.0 / 3.0)) + hometown;

        if (year == "leap")  // leap yaer
        {
            x = x * 1.15;
        }
        Console.WriteLine(Math.Floor(x));
    }
}