using System;
public class KingOfThieves
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char gemSymbol = Console.ReadLine()[0];

        int outerDashes = size / 2;
        int innerSymbols = 1;

        for (int row = 0; row < size; row++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string(gemSymbol, innerSymbols));

            if (row < size / 2) { outerDashes--; innerSymbols += 2; }
            else { outerDashes++; innerSymbols -= 2; }
        }
    }
}