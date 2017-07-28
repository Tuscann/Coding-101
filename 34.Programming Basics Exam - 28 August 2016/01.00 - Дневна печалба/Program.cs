using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double dolar = double.Parse(Console.ReadLine());

        double total = (n * m) * 12 + (n * m) * 2.5;
        double danak = 0.25 * total;
        double ostatak = (total - danak) * dolar;
        double den = ostatak / 365;

        Console.WriteLine("{0:f2}", den);
    }
}