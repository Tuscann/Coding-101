using System;
class Program
{
    static void Main()
    {
        int lillyAge = int.Parse(Console.ReadLine());
        decimal priceLaundry = decimal.Parse(Console.ReadLine());
        long pricePerToy = long.Parse(Console.ReadLine());
        int countToys = 0;
        int savedMoney = 0;
        int totalSavedMoney = 0;
        int countTakenMoney = 0;

        for (int year = 1; year <= lillyAge; year++)
        {
            if (year % 2 == 0)
            {
                savedMoney +=10;
                totalSavedMoney +=  savedMoney;
                countTakenMoney++;
            }
            else
            {
                countToys++;
            }
        }
        long moneyOfSoldToys = countToys * pricePerToy;
        decimal finalMoney = (totalSavedMoney + moneyOfSoldToys) - countTakenMoney;

        if (finalMoney >= priceLaundry)
        {
            Console.WriteLine("Yes! {0:f2}", finalMoney - priceLaundry);
        }
        else
        {
            Console.WriteLine("No! {0:f2}", priceLaundry - finalMoney);
        }
    }
}