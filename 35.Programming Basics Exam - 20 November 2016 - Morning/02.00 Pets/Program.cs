using System;
class Program
{
    static void Main()
    {
        decimal days = decimal.Parse(Console.ReadLine());
        decimal foodInKilograms = decimal.Parse(Console.ReadLine());
        decimal foodDog = decimal.Parse(Console.ReadLine());
        decimal foodCat = decimal.Parse(Console.ReadLine());
        decimal foodturtleGRAMS = decimal.Parse(Console.ReadLine());

        decimal total = days * foodDog + days * foodCat + (foodturtleGRAMS * days / 1000);

        if (total <= foodInKilograms)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(foodInKilograms - total));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(Math.Abs(total - foodInKilograms)));
        }
    }
}