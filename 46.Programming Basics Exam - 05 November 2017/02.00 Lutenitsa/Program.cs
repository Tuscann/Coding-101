using System;
class Program
{
    static void Main()  // 100/100
    {
        decimal quantityTomatoes = decimal.Parse(Console.ReadLine());
        int boxesCount = int.Parse(Console.ReadLine());
        int jarCount = int.Parse(Console.ReadLine());

        decimal kilograms = quantityTomatoes / (decimal)5.0;
        decimal jars = kilograms / (decimal)0.535;
        decimal leftBoxes = jars / jarCount;

        Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(kilograms));
        if (leftBoxes >= boxesCount)
        {
            Console.WriteLine("{0} boxes left.", Math.Floor(leftBoxes - boxesCount));
            decimal jarsleft = jars - boxesCount * jarCount;

            Console.WriteLine("{0} jars left.", Math.Floor(jarsleft));
        }
        else
        {
            Console.WriteLine("{0} more boxes needed.", Math.Floor(boxesCount - leftBoxes));
            decimal jarsleft = boxesCount * jarCount - jars;

            Console.WriteLine("{0} more jars needed.", Math.Floor(jarsleft));
        }
    }
}