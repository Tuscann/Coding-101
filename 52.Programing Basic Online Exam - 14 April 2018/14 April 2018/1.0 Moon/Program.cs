using System;
class Program
{
    static void Main()
    {
        double speed = double.Parse(Console.ReadLine());
        double litersPer100 = double.Parse(Console.ReadLine());

        double totalDistance = 384400 * 2;

        double time = Math.Ceiling(totalDistance / speed) + 3;
        Console.WriteLine(time);
        double fuel = litersPer100 * totalDistance / 100;
        Console.WriteLine(fuel);
    }
}