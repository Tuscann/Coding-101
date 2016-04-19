using System;

class Program
{
    static void Main()
    {
        var gradus = double.Parse(Console.ReadLine());
        var celsisum = gradus * 1.80000 + 32;

        Console.WriteLine("{0:0.00}", celsisum);
    }
}

