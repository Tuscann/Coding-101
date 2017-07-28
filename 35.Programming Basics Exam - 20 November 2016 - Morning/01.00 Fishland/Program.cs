using System;
class Program
{
    static void Main()
    {
        double Zenaskumriq = double.Parse(Console.ReadLine());
        double Zenazaza = double.Parse(Console.ReadLine());
        double palamud = double.Parse(Console.ReadLine());
        double safrid = double.Parse(Console.ReadLine());
        double midi = double.Parse(Console.ReadLine());

        double total = Zenaskumriq * 1.60 * palamud + Zenazaza * 1.8 * safrid + midi * 7.50;

        Console.WriteLine("{0:f2}", total);
    }
}