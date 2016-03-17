using System;
class Program
{
    static void Main()
    {
        int attemps = int.Parse(Console.ReadLine());

        long thievesSlapped = 0;
        long totalBeers = 0;
        long thievesEscapped = 0;
        
        for (long i = 0; i < attemps; i++)
        {
            long thieves = long.Parse(Console.ReadLine());
            long beers = long.Parse(Console.ReadLine());

            if (thieves>5)
            {
                thievesEscapped = thieves + thievesEscapped - 5;
                thievesSlapped = thievesSlapped + 5;
                totalBeers = totalBeers + beers;
            }
            else
            {
                thievesSlapped = thievesSlapped + thieves;
                totalBeers = totalBeers + beers;
            }
        }
        Console.WriteLine("{0} thieves slapped.\n{1} thieves escaped.\n{2} packs, {3} bottles.", thievesSlapped, thievesEscapped, totalBeers/6, totalBeers%6);
    }
}

