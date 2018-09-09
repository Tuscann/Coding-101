using System;

class Programs
{
    static void Main()
    {
        int restTime = int.Parse(Console.ReadLine());
        decimal peripherialPrice = decimal.Parse(Console.ReadLine());
        decimal programPrice = decimal.Parse(Console.ReadLine());
        decimal whiteFrapsPrice = decimal.Parse(Console.ReadLine());

        int relaxTime = restTime - 15;
        decimal moneySpent = 3 * peripherialPrice + 2 * programPrice + whiteFrapsPrice;

        Console.WriteLine($"{moneySpent:F2}");
        Console.WriteLine(relaxTime);
    }
}