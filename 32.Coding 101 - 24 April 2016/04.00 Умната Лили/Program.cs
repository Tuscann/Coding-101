using System;
class Program
{
    static void Main() // 100/100
    {
        decimal years = decimal.Parse(Console.ReadLine());
        decimal washingMachine = decimal.Parse(Console.ReadLine());
        int toy = int.Parse(Console.ReadLine());

        decimal evenCounter = 0;
        decimal oddCounter = 0;
        decimal total = 0;

        for (decimal i = 0; i < years; i++)
        {
            oddCounter = years / 2;

            if (years % 2 != 0) { oddCounter++; }
            evenCounter = years / 2;
        }
        int sborNaChislata = 0, j;

        for (j = 0; j <= years; j = j + 2)
        {
            sborNaChislata += j;
        }
        total = sborNaChislata * 5;

        decimal totalPlus = (int)oddCounter * toy;
        decimal savedMoney = total + totalPlus - (int)evenCounter;

        if (savedMoney >= washingMachine)
        {
            Console.WriteLine("Yes! {0:f2}", savedMoney - washingMachine);
        }
        else
        {
            Console.WriteLine("No! {0:f2}", Math.Abs(washingMachine - savedMoney));
        }
    }
}