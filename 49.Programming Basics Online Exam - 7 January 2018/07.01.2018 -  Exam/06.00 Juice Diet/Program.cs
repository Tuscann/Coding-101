using System;
class Program
{
    static void Main() // 100/100
    {
        int raspberries = int.Parse(Console.ReadLine());
        int strawberries = int.Parse(Console.ReadLine());
        int cherries = int.Parse(Console.ReadLine());
        double juiceAllowed = double.Parse(Console.ReadLine());

        double juice = 0;
        int ras = 0;
        int str = 0;
        int chr = 0;

        for (int raspberry = 0; raspberry <= raspberries; raspberry++)
        {
            for (int strawberry = 0; strawberry <= strawberries; strawberry++)
            {
                for (int cherry = 0; cherry <= cherries; cherry++)
                {
                    double juiceMade = raspberry * 4.5 + strawberry * 7.5 + cherry * 15.0;

                    if (juiceAllowed >= juiceMade && juiceMade > juice)
                    {
                        juice = juiceMade;
                        chr = cherry;
                        ras = raspberry;
                        str = strawberry;
                    }
                }
            }
        }
        Console.WriteLine("{0} Raspberries, {1} Strawberries, {2} Cherries. Juice: {3} ml.", ras, str, chr, juice);
    }
}