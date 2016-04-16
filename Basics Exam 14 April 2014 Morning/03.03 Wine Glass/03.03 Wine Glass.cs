using System;
class WineGlass
{
    const char GlassFillingSymbol = '*';
    const char EmptySpaceSymbol = '.';

    static void Main()
    {
        // Read a positive, even number 
        int n = int.Parse(Console.ReadLine());
        int borderSpacing = 0;
        int middleSpacing = n - 2;

        for (int i = 0; i < n; i++)
        {
            // For the first half we print the upper part (bowl) of the glass
            if (i < n / 2)
            {
                string dots = new string(EmptySpaceSymbol, borderSpacing);
                string asterisks = new string(GlassFillingSymbol, middleSpacing);
                Console.WriteLine(dots + '\\' + asterisks + '/' + dots);
                borderSpacing++;
                middleSpacing -= 2;
            }
            // After that we print the stem according to the rules
            else if (n < 12 && i < n - 1 || n >= 12 && i < n - 2)
            {
                string dots = new string(EmptySpaceSymbol, n / 2 - 1);
                Console.WriteLine(dots + '|' + '|' + dots);
            }
            // Finally we print the foot of the glass
            else
            {
                Console.WriteLine(new string('-', n));
            }
        }
    }
}
