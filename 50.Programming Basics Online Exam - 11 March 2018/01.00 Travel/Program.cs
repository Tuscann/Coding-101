using System;
class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double v = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double sum = v + y * 3.6;
        Console.WriteLine("The truck arrived after {0} hours", Math.Ceiling(x / v));
        Console.WriteLine("The car arrived after {0} hours", Math.Ceiling(x / sum));
    }
}