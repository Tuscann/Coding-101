using System;
class Program
{
    static void Main()
    {
        int minutesPerDay = int.Parse(Console.ReadLine());
        int walksPerDay = int.Parse(Console.ReadLine());
        int callories = int.Parse(Console.ReadLine());

        var total = minutesPerDay * walksPerDay * 5;

        if (total >= callories / 2.0)
        {
            Console.WriteLine("Yes, the walk for your cat is enough. Burned calories per day: {0:f0}.", total);
        }
        else
        {
            Console.WriteLine("No, the walk for your cat is not enough. Burned calories per day: {0:f0}.", total);
        }
    }
}