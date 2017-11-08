using System;
class Program
{
    static void Main()    // 100/100
    {
        int hours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int employer = int.Parse(Console.ReadLine());

        double realHours = 0.90 * days * 8;
        int add = employer * 2 * days;

        double total = Math.Floor(realHours + add);

        if (total >= hours)
        {
            Console.WriteLine("Yes!{0} hours left.", total - hours);
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", hours - total);
        }
    }
}