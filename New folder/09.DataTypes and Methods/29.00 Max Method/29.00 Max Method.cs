using System;

internal class Program
{
    private static void Main()
    {
        decimal max = decimal.MinValue;

        for (decimal i = 0; i <= 2; i++)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            if (n >= max)
            {
                max = n;
            }
        }
        Console.WriteLine("{0}", max);
    }
}