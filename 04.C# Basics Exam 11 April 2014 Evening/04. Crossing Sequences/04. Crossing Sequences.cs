using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        var a = ulong.Parse(Console.ReadLine());
        var b = ulong.Parse(Console.ReadLine());
        var c = ulong.Parse(Console.ReadLine());
        var spiralStart = ulong.Parse(Console.ReadLine());
        var spiralStep = ulong.Parse(Console.ReadLine());
        var trib = new List<ulong> {a, b, c};
        var spiral = new List<ulong> {spiralStart};
        var check = false;

        while (c < 1000000)
        {
            var ctemp = c;
            c = a + b + c;
            a = b;
            b = ctemp;
            trib.Add(c);
        }
        for (ulong poss = 1; spiralStart < 1000000; poss++)
        {
            for (var m = 0; m < 2; m++)
            {
                var spiralStartTemp = spiralStart + poss*spiralStep;
                spiral.Add(spiralStartTemp);
                spiralStart = spiralStartTemp;
            }
        }

        foreach (ulong item in trib)
        {
            if (spiral.Contains(item))
            {
                Console.WriteLine(item);
                check = true;
                return;
            }
            
        }
        if (!check)
        {
            Console.WriteLine("No");
        }

    }
}