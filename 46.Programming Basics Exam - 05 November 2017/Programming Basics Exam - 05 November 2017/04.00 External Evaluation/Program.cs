using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double p22 = 0.0;
        double p40 = 0.0;
        double p58 = 0.0;
        double p76 = 0.0;
        double p100 = 0.0;

        for (int i = 0; i < n; i++)
        {
            double current = double.Parse(Console.ReadLine());

            if (current <= 22.5)
            {
                p22++;
            }
            else if (current > 22.5 && current <= 40.5)
            {
                p40++;
            }
            else if (current > 40.5 && current <= 58.5)
            {
                p58++;
            }
            else if (current <= 76.5)
            {
                p76++;
            }
            else if (current <= 100)
            {
                p100++;
            }
        }
        double x = 0.0;

        if (p22 != 0.0)
        {
            x = 100.0 / (n / p22);
            p22 = x;

        }
        if (p40 != 0.0)
        {
            x = 100.0 / (n / p40);
            p40 = x;
        }
        if (p58 != 0.0)
        {
            x = 100.0 / (n / p58);
            p58 = x;
        }
        if (p76 != 0.0)
        {
            x = 100.0 / (n / p76);
            p76 = x;
        }
        if (p100 != 0.0)
        {
            x = 100.0 / (n / p100);
            p100 = x;
        }
        Console.WriteLine("{0:f2}% poor marks", p22);
        Console.WriteLine("{0:f2}% satisfactory marks", p40);
        Console.WriteLine("{0:f2}% good marks", p58);
        Console.WriteLine("{0:f2}% very good marks", p76);
        Console.WriteLine("{0:f2}% excellent marks", p100);
    }
}