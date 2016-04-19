using System;
class Program
{
    static void Main()
    {

        double n = double.Parse(Console.ReadLine());

        double max = 0;
        double total = 0;

        for (double i = 0; i < n; i++)
        {
            double read = double.Parse(Console.ReadLine());

            if (read > max)
            {
                max = read;
            }
            total += read;
        }

        if (total - max == max)
        {
            Console.WriteLine("Yes\nSum = {0}", max);
        }
        else
        {
            Console.WriteLine("No\nDiff = {0}", Math.Abs(max - (total - max)));
        }
    }
}

