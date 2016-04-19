using System;
class Program
{
    static void Main()
    {

        var n = int.Parse(Console.ReadLine());
        var len = 0;
        var maxLent = 0;
        var prev = 0;
        for (int number = 0; number < n; number++)
        {
            var num = int.Parse(Console.ReadLine());

            if ((num > prev) || (number == 0)) { len++; }

            else{len = 1;}

            if (len > maxLent) maxLent = len;{prev = num;}
        }

        Console.WriteLine(maxLent);
    }
}

