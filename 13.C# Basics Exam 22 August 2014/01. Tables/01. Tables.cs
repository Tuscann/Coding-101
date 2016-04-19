using System;
class Program
{
    static void Main()
    {

        long budle1 = long.Parse(Console.ReadLine());
        long budle2 = long.Parse(Console.ReadLine());
        long budle3 = long.Parse(Console.ReadLine());
        long budle4 = long.Parse(Console.ReadLine());
        int tableTops = int.Parse(Console.ReadLine());
        int neededTables = int.Parse(Console.ReadLine());

        long legs = 1 * budle1 + 2 * budle2 + 3 * budle3 + 4 * budle4;
        long legsLeft = legs - tableTops * 4;  ///da se izpozlava
        long legsPossibleTables = legs / 4;
        long possibleTables = Math.Abs((int)(legsPossibleTables) - tableTops);
        
        if (legsPossibleTables > tableTops){possibleTables = legsPossibleTables - possibleTables;}
        else if (tableTops > legsPossibleTables){possibleTables = tableTops - possibleTables;}
        else{possibleTables = tableTops;}
        
        long tablesNeed = possibleTables - neededTables;
        long legsneed = legsPossibleTables - neededTables;
        long topsneed = tableTops - neededTables;

        if (tablesNeed == 0){Console.WriteLine("Just enough tables made: {0}", neededTables);}
        else if (possibleTables > neededTables)
        {
            Console.WriteLine("more: {0} ", Math.Abs(tablesNeed));
            Console.WriteLine("tops left: {0}, legs left: {1}", Math.Abs(topsneed), Math.Abs(legsneed * 4));
        }

        else // if (need > possibleTables)
        {
            Console.WriteLine("less: {0} ", tablesNeed);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", Math.Abs(topsneed), Math.Abs(legsneed * 4));
        }


    }
}



