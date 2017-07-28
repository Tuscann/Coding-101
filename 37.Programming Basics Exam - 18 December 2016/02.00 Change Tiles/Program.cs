using System;
internal class Program
{
    public static void Main()
    {
        decimal takemoney = decimal.Parse(Console.ReadLine());
        decimal weight = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());
        decimal a = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());
        decimal prize = decimal.Parse(Console.ReadLine());
        decimal maistor = decimal.Parse(Console.ReadLine());

        decimal x = weight * height / (a * h / 2);

        decimal total = Math.Ceiling(x) + 5;
        decimal y = total * prize + maistor;

        if (y <= takemoney)
        {
            Console.WriteLine("{0:f2} lv left.", takemoney - y);
        }
        else
        {
            Console.WriteLine("You'll need {0:f2} lv more.", y - takemoney);
        }
    }
}