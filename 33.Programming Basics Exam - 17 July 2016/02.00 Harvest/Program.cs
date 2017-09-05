using System;
class Program
{
    static void Main() // 100/100
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        decimal z = decimal.Parse(Console.ReadLine());
        decimal count = decimal.Parse(Console.ReadLine());

        decimal total = (decimal)0.4 * ((x * y) / (decimal)2.5);

        if (total >= z)
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(total));
            Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(total - z), Math.Ceiling((total - z) / count));
        }
        else
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z - total));
        }
    }
}