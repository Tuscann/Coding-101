using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers:");
        var sum = 0;
        for (var i = 0; i < n; i++)
        { var num = int.Parse(Console.ReadLine()); sum = sum + num; }
        Console.WriteLine("{0}", sum);

    }
}

