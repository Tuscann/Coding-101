using System;

class Program
{
    static void Main(string[] args)
    {

        double price = double.Parse(Console.ReadLine());
        double partyDays = double.Parse(Console.ReadLine());

        double savings = ((30 - partyDays) * 2) - (5 * partyDays);
        //Console.WriteLine(monthlyBalance);

        if (savings < 0) { Console.WriteLine("never");}
        else
        {
            double neededMonhts = Math.Ceiling(price / savings);

            //Console.WriteLine(years);
            double years  = neededMonhts / 12;

            //Console.WriteLine(monts );
            double mounts = neededMonhts % 12;

            //Console.WriteLine(monts);
            Console.WriteLine("{0:f0} years, {1:f0} months",Math.Floor(years), mounts);
        }
    }
}

