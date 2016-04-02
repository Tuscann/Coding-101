using System;
class Program
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());


        double moon = 0.17 * weight;

        Console.WriteLine("{0:f3}", moon);
    }
}

