using System;
class Program
{
    static void Main()
    {
        decimal magnoliii = decimal.Parse(Console.ReadLine());
        decimal zumbuli = decimal.Parse(Console.ReadLine());
        decimal rozi = decimal.Parse(Console.ReadLine());
        decimal kaktuzi = decimal.Parse(Console.ReadLine());
        decimal prizeGift = decimal.Parse(Console.ReadLine());

        decimal total = (magnoliii * (decimal)3.25 + zumbuli * (decimal)4 + rozi * (decimal)3.5 + kaktuzi * (decimal)8) * (decimal)0.95;

        if (total < prizeGift)
        {
            Console.WriteLine("She will have to borrow {0} leva. ", Math.Ceiling(prizeGift - total));
        }
        else
        {
            Console.WriteLine("She is left with {0} leva.", Math.Floor(Math.Abs(total - prizeGift)));
        }
    }
}