using System;
class Program
{
    static void Main()
    {
        decimal dolarRate = 1.72m;
        decimal evroRate = 1.94m;
        decimal pesos = 332.74m;
        
        decimal albumsEurope = decimal.Parse(Console.ReadLine());
        decimal evroprice = decimal.Parse(Console.ReadLine());
        decimal albumsNorthAmerica = decimal.Parse(Console.ReadLine());
        decimal dollarsPrice = decimal.Parse(Console.ReadLine());
        decimal albumsSouthamerica = decimal.Parse(Console.ReadLine());
        decimal pesosprice = decimal.Parse(Console.ReadLine());
        decimal concertsDuringTour = decimal.Parse(Console.ReadLine());
        decimal moneyConcerEuro = decimal.Parse(Console.ReadLine());

        decimal Europe = albumsEurope * evroprice * evroRate;
        decimal NorthAmerica = albumsNorthAmerica * dollarsPrice * dolarRate;
        decimal Southamerica = albumsSouthamerica * pesosprice / pesos;
        decimal allAlbums = Europe + NorthAmerica + Southamerica;

        decimal totalallAlbums = (allAlbums * 0.65m) * 0.80m;
      
        decimal concertProfit = concertsDuringTour * moneyConcerEuro * evroRate;
      
        if (concertProfit > 100000){concertProfit = concertProfit * 0.85m;}
       
        if (concertProfit >= totalallAlbums)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", concertProfit);
        }
        else
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", totalallAlbums);
        }

    }
}
