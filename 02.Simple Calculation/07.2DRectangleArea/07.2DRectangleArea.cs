using System;

class Program
{
    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        
        var area = 2 * (Math.Abs(x2 - x1) + Math.Abs(y1 - y2));
        var perimmeter = Math.Abs(x2 - x1) * Math.Abs(y1 - y2);

        Console.WriteLine("{0}", perimmeter);
        Console.WriteLine("{0}", area);
    }
}

