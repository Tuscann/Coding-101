using System;
class Program
{
    static void Main()
    {

        double a1 = double.Parse(Console.ReadLine());
        double a2 = double.Parse(Console.ReadLine());
        double a3 = double.Parse(Console.ReadLine());
        double a4 = double.Parse(Console.ReadLine());

        double total = (a1 * a3 + a2 * a4) / (double)1.94;
        Console.WriteLine($"{total}");
    }
}

