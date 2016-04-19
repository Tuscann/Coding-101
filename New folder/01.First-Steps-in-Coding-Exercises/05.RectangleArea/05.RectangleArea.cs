using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("a = ");
        var a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        var b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle Area:{0}", a * b);
    }
}
