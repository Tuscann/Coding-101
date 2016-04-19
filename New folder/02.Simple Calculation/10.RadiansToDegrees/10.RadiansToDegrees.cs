using System;

class Program
{
    static void Main()
    {
        var radians = double.Parse(Console.ReadLine());
        var gradus = radians * 180 / Math.PI;
        Console.WriteLine("{0}", Math.Round(gradus));
    }
}

