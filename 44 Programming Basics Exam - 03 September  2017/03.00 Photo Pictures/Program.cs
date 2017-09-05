using System;
class Program
{
    static void Main() // 100/100
    {
        int countFotos = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string typeOfOrder = Console.ReadLine();

        double onePeisePrize = 0;
        double countDiscount = 1;

        if (type == "9X13")
        {
            onePeisePrize = 0.16;
            if (countFotos >= 50)
            {
                countDiscount = 0.95;
            }
        }
        else if (type == "10X15")
        {
            onePeisePrize = 0.16;
            if (countFotos >= 80)
            {
                countDiscount = 0.97;
            }
        }
        else if (type == "13X18")
        {
            onePeisePrize = 0.38;
            if (countFotos >= 50 && countFotos <= 100)
            {
                countDiscount = 0.97;
            }
            if (countFotos > 100)
            {
                countDiscount = 0.95;
            }
        }
        else if (type == "20X30")
        {
            onePeisePrize = 2.90;
            if (countFotos >= 10 && countFotos <= 50)
            {
                countDiscount = 0.93;
            }
            if (countFotos > 50)
            {
                countDiscount = 0.91;
            }
        }
        double sum = countFotos * onePeisePrize * countDiscount;

        if (typeOfOrder == "online")
        {
            sum = countFotos * onePeisePrize * countDiscount * 0.98;
        }
        Console.WriteLine("{0:f2}BGN", sum);
    }
}