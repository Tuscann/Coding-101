using System;
class Program
{
    static void Main()
    {
        var n = decimal.Parse(Console.ReadLine());
        var m = decimal.Parse(Console.ReadLine());
        
        for (decimal i = n; i <= m; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0:f3}", Math.Sqrt((double)i));
            }
            else
            {
                Console.WriteLine("{0:f3}", i * i);
            }
        }
    }
}