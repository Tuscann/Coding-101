using System;
class Program
{
    static void Main()
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var third = int.Parse(Console.ReadLine());

        var secondsSum = first + second + third;
        var minutes = first + second + third / 60;
        var seconds = secondsSum % 60;

        Console.WriteLine("{0:0}:{1:00}", minutes, seconds);

    }
}

