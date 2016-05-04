using System;
class Program
{
    static void Main()
    {
        uint reserveedBeer = uint.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        long beerCount = 0;

        while (input != "Exam Over")
        {
            string[] parameters = input.Split();
            long amount = long.Parse(parameters[0]);
            string type = parameters[1];

            if (type == "beers") { beerCount = beerCount + amount; }
            if (type == "cases") { beerCount = beerCount + amount * 24; }
            if (type == "sixpacks") { beerCount = beerCount + amount * 6; }

            input = Console.ReadLine();
        }
        beerCount = beerCount - (beerCount / 100);
        if (beerCount < reserveedBeer)
        {
            long needBeers = reserveedBeer - beerCount;
            long cases = needBeers / 24;
            long beerLeft = needBeers % 24;
            long sixpack = beerLeft / 6;
            long beersLeftss = beerLeft % 6;

            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beersLeftss);
        }
        else if (beerCount >= reserveedBeer)
        {
            long needBeers = beerCount - reserveedBeer;
            long cases = needBeers / 24;
            long beerLeft = needBeers % 24;
            long sixpack = beerLeft / 6;
            long beersLeftss = beerLeft % 6;

            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beersLeftss);
        }
    }
}