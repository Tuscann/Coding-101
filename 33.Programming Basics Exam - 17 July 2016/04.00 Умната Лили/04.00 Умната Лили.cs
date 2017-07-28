using System;
class Program
{
    static void Main()
    {
        int years = int.Parse(Console.ReadLine());
        decimal washingMachine = decimal.Parse(Console.ReadLine());
        int toy = int.Parse(Console.ReadLine());

        int evenCounter = 0;
        int oddCounter = 0;
        int moneyForBirthday = 10/2;

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
        total = sborNaChislata * moneyForBirthday;   /* sborNaChislata = sum of all odd number */

        decimal totalPlus = oddCounter * toy;

        decimal savedMoney = total + totalPlus - evenCounter;
        
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