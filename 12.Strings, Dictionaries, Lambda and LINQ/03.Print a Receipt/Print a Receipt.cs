using System;
using System.Linq;
class Program
{
    static void Main()
    {
       var arrays = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Console.WriteLine("/----------------------\\");
        foreach (var array in arrays)
        {
            Console.WriteLine("|{0,21:f2} |",array);
        }
        Console.WriteLine("|----------------------|");
        Console.WriteLine("| Total:{0,14:f2} |", arrays.Sum());
        Console.WriteLine("\\----------------------/");
    }
}

