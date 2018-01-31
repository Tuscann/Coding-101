using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
                 if (num < 200) { p1++; }
            else if (num < 400) { p2++; }
            else if (num < 600) { p3++; }
            else if (num < 800) { p4++; }
            else if (num <= 1000) { p5++; }
        }
        double p1Percentage = p1 * 100d / n;
        double p2Percentage = p2 * 100d / n;
        double p3Percentage = p3 * 100d / n;
        double p4Percentage = p4 * 100d / n;
        double p5Percentage = p5 * 100d / n;


        Console.WriteLine("{0:f2}%", p1Percentage);
        Console.WriteLine("{0:f2}%", p2Percentage);
        Console.WriteLine("{0:f2}%", p3Percentage);
        Console.WriteLine("{0:f2}%", p4 * 100d / n);
        Console.WriteLine("{0:f2}%", p5 * 100d / n);
    }
}

