using System;

class Program
{
    static void Main() // 100/100
    {
        double with = double.Parse(Console.ReadLine());
        double lenght = double.Parse(Console.ReadLine());
        double sandPrice = double.Parse(Console.ReadLine());
        double woodenBrick = double.Parse(Console.ReadLine());

        double total = with * lenght;
        double sandBox = (with - 0.2 * 2.0) * (lenght - 0.2 * 2.0);
        double burduri = total - sandBox;
        double neededSand = Math.Ceiling(sandBox * 20);
        double neededWood = Math.Ceiling(burduri / (2.2 * 0.2));
        double totals = neededSand * sandPrice + neededWood * woodenBrick;

        Console.WriteLine("{0:f2}", totals);
    }
}