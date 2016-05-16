using System;
class Program
{
    static void Main()
    {
       Console.WriteLine("{0}", Math.Round(double.Parse(Console.ReadLine()) * 180 / Math.PI));
    }
}