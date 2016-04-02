using System;
class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.00} {1:0.00}",width*height,2*width+2*height);
    }
}

