using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var number = Console.ReadLine().Split().ToArray().Reverse();

        Console.WriteLine(string.Join(" ", number));
    }
}

