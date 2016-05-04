using System;
class Program
{
    private static void Main()
    {
        //double max = double.MinValue;

        //for (double i = 0; i <= 2; i++)
        //{
        //    double n = double.Parse(Console.ReadLine());

        //    if (n >= max)
        //    {
        //        max = n;
        //    }
        //}
        //Console.WriteLine("{0}", max);

        double x1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());

        double x = Math.Max(x1, Math.Max(x2, x3));

        Console.WriteLine(x);

    }
}