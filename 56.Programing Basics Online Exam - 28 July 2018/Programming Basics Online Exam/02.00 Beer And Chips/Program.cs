using System;

internal class Program
{
    public static void Main()
    {
        String nameFan = Console.ReadLine();
        double budjet = double.Parse(Console.ReadLine());
        int countBottles = int.Parse(Console.ReadLine());
        int countChips = int.Parse(Console.ReadLine());

        double total = 1.20 * countBottles + Math.Ceiling((0.45 * 1.20 * countBottles) * countChips);

        if (total <= budjet)
        {
            Console.WriteLine(nameFan + " bought a snack and has {0:f2} leva left.", budjet - total);
        }
        else
        {
            Console.WriteLine(nameFan + " needs {0:f2} more leva!", total - budjet);
        }
    }
} 