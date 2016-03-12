using System;

class Program
{
    static void Main()
    {
        Console.Write("inches = ");
        var inches = double.Parse(Console.ReadLine());
        Console.WriteLine("centimeters = {0}", inches * 2.54);
    }
}

