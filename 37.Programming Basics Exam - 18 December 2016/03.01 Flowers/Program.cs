using System;
internal class Program
{
    public static void Main()
    {
        decimal hrizantemi = decimal.Parse(Console.ReadLine());
        decimal roze = decimal.Parse(Console.ReadLine());
        decimal laleta = decimal.Parse(Console.ReadLine());
        string seacon = Console.ReadLine();
        string happyDay = Console.ReadLine();

        decimal total = 0;

        if (seacon == "Spring")
        {
            total = hrizantemi * (decimal)2 + roze * (decimal)4.10 + laleta * (decimal)2.5;

            if (happyDay == "Y")
            {
                total *= (decimal)1.15;
            }
            if (laleta > 7)
            {
                total *= (decimal)0.95;
            }
            if (hrizantemi + roze + laleta > 20)
            {
                total *= (decimal)0.8;
            }
        }
        else if (seacon == "Winter")
        {
            total = hrizantemi * (decimal)3.75 + roze * (decimal)4.5 + laleta * (decimal)4.15;

            if (happyDay == "Y")
            {
                total *= (decimal)1.15;
            }
            if (roze > 10)
            {
                total *= (decimal)0.9;
            }
            if (hrizantemi + roze + laleta > 20)
            {
                total *= (decimal)0.8;
            }
        }
        else if (seacon == "Autumn")
        {
            total = hrizantemi * (decimal)3.75 + roze * (decimal)4.5 + laleta * (decimal)4.15;

            if (happyDay == "Y")
            {
                total *= (decimal)1.15;
            }
            if (hrizantemi + roze + laleta > 20)
            {
                total *= (decimal)0.8;
            }
        }
        else
        {
            total = hrizantemi * (decimal)2 + roze * (decimal)4.10 + laleta * (decimal)2.5;

            if (happyDay == "Y")
            {
                total *= (decimal)1.15;
            }
            if (hrizantemi + roze + laleta > 20)
            {
                total *= (decimal)0.8;
            }
        }
        Console.WriteLine("{0:f2}", total + 2);
    }
}