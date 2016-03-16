using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minArea = int.Parse(Console.ReadLine());

        var PrintNo = true;

        for (var left = -n; left <= n; left++)
        {
            for (var top = -n; top <= n; top++)
            {
                for (var right = left + 1; right <= n; right++)
                {
                    for (var bottom = top + 1; bottom <= n; bottom++)
                    {
                        var width = right - left;
                        var height = bottom - top;
                        var area = width * height;
                        if (area >= minArea)
                        {
                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                            PrintNo = false;
                        }
                    }
                }
            }
        }
        if (PrintNo) { Console.WriteLine("No"); }
    }
}

