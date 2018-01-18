using System;

class Program
{
    static void Main()   // 100/100
    {
        int missingDays = int.Parse(Console.ReadLine());
        int foodKilograams = int.Parse(Console.ReadLine());
        double deerFoodKilograms1 = double.Parse(Console.ReadLine());
        double deerFoodKilograms2 = double.Parse(Console.ReadLine());
        double deerFoodKilograms3 = double.Parse(Console.ReadLine());

        double total = missingDays * (deerFoodKilograms1 + deerFoodKilograms2 + deerFoodKilograms3);

        if (total < foodKilograams)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor( foodKilograams- total));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(total- foodKilograams));
        }
    }
}