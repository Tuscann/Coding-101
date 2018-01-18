using System;
class Program
{
    static void Main()
    {
        var num = Console.ReadLine();

        for (int q = 1; q <= int.Parse(num[2].ToString()); q++)
        {
            for (int w = 1; w <= int.Parse(num[1].ToString()); w++)
            {
                for (int e = 1; e <= int.Parse(num[0].ToString()); e++)
                {
                    Console.WriteLine($"{q} * {w} * {e} = {q * w * e};");
                }
            }
        }
    }
}