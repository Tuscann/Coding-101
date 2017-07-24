using System;
class Program
{
    static void Main()
    {
        double L = double.Parse(Console.ReadLine());
        double W = double.Parse(Console.ReadLine());
        double A = double.Parse(Console.ReadLine());
        
        double sum = L * 100 * W * 100;
        double garderob = A * 100 * A * 100;
        double skameika = sum / 10;

        double summm = (sum - garderob - skameika) / (40 + 7000);

        Console.WriteLine(Math.Floor(summm));
    }
}

