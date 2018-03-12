using System;
class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double v = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double sum = v + y * 3.6;
        Console.WriteLine("The truck arrived after " + Math.Ceiling(x / v) + " hours");
        Console.WriteLine("The car arrived after " + Math.Ceiling(x / sum) + " hours");
    }
}