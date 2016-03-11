using System;
using System.Runtime.InteropServices;

class TriangleArea
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());

        var area = a*h/2;

        Console.WriteLine( "Triangle area = {0:0.00}",area);
    }
}

