using System;
class Program
{
    static void Main()
    {
        var a = decimal.Parse(Console.ReadLine());
        var b = decimal.Parse(Console.ReadLine());

        //var first = (decimal)-0.0000007;
        //var second = (decimal)-0.0000007;

        if ((b - a == (decimal)0.000001) || a - b == (decimal)0.000001)
        {
            Console.WriteLine("false");
        }
        else if (a * -1 == (b) || (a == b * -1) || (float)a == (float)b)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}