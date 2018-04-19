using System;
class Program
{
    static void Main()
    {
        int peoples = int.Parse(Console.ReadLine());
        int voutesForlanguage = int.Parse(Console.ReadLine());

        double secoundlanguage = voutesForlanguage * 0.8;
        double thirdlanguage = secoundlanguage * 0.9;
        double allLanguages = voutesForlanguage + secoundlanguage + thirdlanguage;

        double votediff = Math.Floor(allLanguages - peoples / 2);

        if (votediff >= 0)
        {
            Console.WriteLine("First three languages have {0} votes more", votediff);
        }
        else
        {
            Console.WriteLine("First three languages have {0} votes less of half votes", Math.Abs(votediff));
        }
    }
}