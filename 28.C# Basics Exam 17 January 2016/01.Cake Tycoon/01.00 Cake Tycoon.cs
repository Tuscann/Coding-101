using System;
class Program
{
    static void Main()
    {
        ulong cakesWanted = ulong.Parse(Console.ReadLine());
        double kilosPerCake = double.Parse(Console.ReadLine());
        uint flourKilos = uint.Parse(Console.ReadLine());
        uint trufles = uint.Parse(Console.ReadLine());
        uint trufflesPrice = uint.Parse(Console.ReadLine());

        ulong trufflescost = (ulong)trufles * trufflesPrice;
        double cakesProduced = Math.Floor(flourKilos / kilosPerCake);

        if (cakesProduced < cakesWanted)
        {
            double kilogramsNeeded = kilosPerCake * cakesWanted - flourKilos;
            Console.WriteLine("Can make only {0:f0} cakes, need {1:f2} kg more flour", cakesProduced, kilogramsNeeded);
        }
        else
        {
            double cakeCost = (double)trufflescost / cakesWanted * (double)1.25;
            Console.WriteLine("All products available, price of a cake: {0:f2}", cakeCost);
        }
    }
}