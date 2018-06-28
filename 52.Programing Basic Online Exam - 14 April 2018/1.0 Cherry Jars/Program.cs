using System;
class Program
{
    static void Main()
    {
        int compoteJars = int.Parse(Console.ReadLine());
        int jamJars = int.Parse(Console.ReadLine());

        double count1 = (compoteJars + 1) * 0.3 * 1.05;
        double count2 = (jamJars + 1) * 0.65 * 1.1;

        double p = (count1 + count2) * 3.2;

        Console.WriteLine("{0:f2}", p);
    }
}