using System;
class PointOnSegment
{
    static void Main()
    {
        var first = double.Parse(Console.ReadLine());
        var second = double.Parse(Console.ReadLine());
        var point = double.Parse(Console.ReadLine());

        var left = Math.Min(first, second);
        var right = Math.Max(first, second);
        var leftDistance = Math.Abs(point - left);
        var rightDistance = Math.Abs(point - right);
        var distance = Math.Min(leftDistance, rightDistance);

        if (point >= left && point <= right)
        {
            Console.WriteLine("in\n{0}", distance);
        }
        else
        {
            Console.WriteLine("out\n{0}", distance);
        }
    }
}


