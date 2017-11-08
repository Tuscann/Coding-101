using System;
class Program
{
    static void Main()  // 100/100
    {
        double n = double.Parse(Console.ReadLine());

        int p22 = 0;
        int p40 = 0;
        int p58 = 0;
        int p76 = 0;
        int p100 = 0;

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
        double result1 = p22 / n * 100.0;
        double result2 = p40 / n * 100.0;
        double result3 = p58 / n * 100.0;
        double result4 = p76 / n * 100.0;
        double result5 = p100 / n * 100.0;

        Console.WriteLine("{0:f2}% poor marks", result1);
        Console.WriteLine("{0:f2}% satisfactory marks", result2);
        Console.WriteLine("{0:f2}% good marks", result3);
        Console.WriteLine("{0:f2}% very good marks", result4);
        Console.WriteLine("{0:f2}% excellent marks", result5);
    }
}