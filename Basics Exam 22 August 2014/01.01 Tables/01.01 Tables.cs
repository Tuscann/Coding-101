using System;

class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesToBeMade = long.Parse(Console.ReadLine());

        long allLegs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
        long tablesMade = Math.Min((allLegs / 4), tableTops);

        if (tablesMade > tablesToBeMade)
        {
            long topsLeft = tableTops - tablesToBeMade;
            long legsLeft = allLegs - tablesToBeMade * 4;
            Console.WriteLine("more: {0}", tablesMade - tablesToBeMade);
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
        }
        else if (tablesMade < tablesToBeMade)
        {
            long topsNeedd = tablesToBeMade >= tableTops ? tablesToBeMade - tableTops : 0;
            long legsNeeded = tablesToBeMade * 4 >= allLegs ? tablesToBeMade * 4 - allLegs : 0;
            Console.WriteLine("less: {0}", tablesMade - tablesToBeMade);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeedd, legsNeeded);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
    }
}