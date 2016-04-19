using System;
using System.Linq;

class Program
{
    static void Main()
    {

        uint rubles = uint.Parse(Console.ReadLine());
        uint dollars = uint.Parse(Console.ReadLine());
        uint evro = uint.Parse(Console.ReadLine());
        uint levaOfferB = uint.Parse(Console.ReadLine());
        uint levaMSite = uint.Parse(Console.ReadLine());
        
        double rubless = (rubles / (double)100) ;
        //Console.WriteLine(rubless);
        double rublesss = rubless*(double) 3.5;
        //Console.WriteLine(rublesss);
        double dollarss = dollars * (double )1.5;
        //Console.WriteLine(dollarss);
        double evros = evro * (double)1.95;
        //Console.WriteLine(evros);
        double levaOfferBB = levaOfferB / (double)2;
        //Console.WriteLine(levaOfferBB);
        //Console.WriteLine(levaMSite);

        double[] numbers = new[] {rublesss, dollarss, evros, levaOfferBB, levaMSite};
        double min = numbers.Min();

        
        Console.WriteLine("{0:f2}",min);

    }
}

